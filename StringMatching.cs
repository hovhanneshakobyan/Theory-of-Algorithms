using System;
using System.Collections.Generic;

public class StringMatching
{
    public static void Main(string[] args)
    {
        string pattern = "aab";
        string text = "acaabk";

        string pattern1 = "ccb";
        string text1 = "acaabkaccbabca";

        string dna = "AAATGAACGAAAATCTGT";
        string dnaPattern = "ACGA";

        // Naive
        // Console.WriteLine(NaiveStringMatching(text1.ToCharArray(), pattern1.ToCharArray()));

        // Finite-automata
        FiniteAutomata(text, pattern);

        // Knuth-Morris-Pratt
        // Console.WriteLine(KmpAlgorithm(dna.ToCharArray(), dnaPattern.ToCharArray()));

        // Boyer-Moore
        // Console.WriteLine(string.Join(", ", ShiftTable("зорро".ToCharArray())));
        // Console.WriteLine(BmhSearch("avdakedavra", "ked"));

        // Palindrome
        // Console.WriteLine(Palindrome("tattarralttat"));
        // Console.WriteLine(IsPalindrome("racecar"));

        // Longest palindrome
        // Console.WriteLine(LongestPalindromicSubstring("123abaxyabccbazavkdpupdkvaycecarhellodcracecarijncdjbjc")); // Longest: avkdpupdkva
        // Console.WriteLine(LongestPalindromicSubstring("fhjcspracecarfconedeojv")); // Longest: racecar

        // Find if the string can be Palindromic
        // Console.WriteLine(IsStringPalindromic("ivicc"));
    }

    #region Finite-automata

    private const int CharCount = 256;

    public static int[,] BuildTransitionTable(string pattern)
    {
        int m = pattern.Length;
        var table = new int[m + 1, CharCount];

        for (int state = 0; state <= m; state++)
        {
            for (int c = 0; c < CharCount; c++)
            {
                table[state, c] = GetNextState(pattern, state, (char)c);
            }
        }

        return table;
    }

    public static int GetNextState(string pattern, int state, char c)
    {
        if (state < pattern.Length && pattern[state] == c)
        {
            return state + 1;
        }

        for (int next = state; next > 0; next--)
        {
            if (pattern[next - 1] == c && pattern.Substring(0, next - 1) == pattern.Substring(state - next + 1, next - 1))
            {
                return next;
            }
        }

        return 0;
    }

    public static void FiniteAutomata(string text, string pattern)
    {
        var table = BuildTransitionTable(pattern);
        int state = 0;
        int m = pattern.Length;

        for (int i = 0; i < text.Length; i++)
        {
            state = table[state, text[i]];
            if (state == m)
            {
                Console.WriteLine($"Pattern found at index {i - m + 1}");
            }
        }
    }

    #endregion

    #region String Palindrome Check

    public static bool IsStringPalindromic(string str)
    {
        var charCountMap = new Dictionary<char, int>();

        foreach (var c in str)
        {
            if (charCountMap.ContainsKey(c))
                charCountMap[c]++;
            else
                charCountMap[c] = 1;
        }

        int oddCount = 0;
        foreach (var count in charCountMap.Values)
        {
            if (count % 2 != 0)
            {
                oddCount++;
            }
            if (oddCount > 1)
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsPalindrome(string text)
    {
        int len = text.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (text[i] != text[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    #endregion

    #region Longest Palindromic Substring

    public static string LongestPalindromicSubstring(string text)
    {
        int len = text.Length;
        string longest = string.Empty;

        for (int i = 0; i < len - 1; i++)
        {
            for (int j = i + 1; j <= len; j++)
            {
                string substring = text.Substring(i, j - i);
                if (substring.Length > longest.Length && IsPalindrome(substring))
                {
                    longest = substring;
                }
            }
        }
        return longest;
    }

    #endregion

    #region Boyer-Moore

    public static int BmhSearch(string text, string substring)
    {
        if (substring.Length > text.Length)
        {
            return -1;
        }

        int[] alphabetTable = ShiftTable(substring);
        int i = substring.Length - 1;
        int n = i;

        for (; i < text.Length;)
        {
            if (text.Substring(i - n, n + 1) == substring)
            {
                return i - n;
            }
            i = i + alphabetTable[text[i]];
        }
        return -1;
    }

    public static int[] ShiftTable(string substring)
    {
        var alphabetTable = new int[CharCount];

        for (int i = 0; i < alphabetTable.Length; i++)
        {
            alphabetTable[i] = substring.Length;
        }

        for (int i = 0; i < substring.Length - 1; i++)
        {
            alphabetTable[substring[i]] = substring.Length - i - 1;
        }

        return alphabetTable;
    }

    #endregion

    #region Knuth-Morris-Pratt

    public static int KmpAlgorithm(char[] T, char[] P)
    {
        int n = T.Length;
        int m = P.Length;
        var p = PrefixFunc(P);
        int j = 0;

        for (int i = 0; i < n;)
        {
            if (T[i] == P[j])
            {
                if (j == m - 1)
                {
                    return i - j;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            else
            {
                if (j == 0)
                {
                    i++;
                }
                else
                {
                    j = p[j - 1];
                }
            }
        }
        return -1;
    }

    public static int[] PrefixFunc(char[] T)
    {
        int n = T.Length;
        var p = new int[n];

        for (int i = 1; i < n; i++)
        {
            int j = p[i - 1];
            while (j > 0 && T[j] != T[i])
            {
                j = p[j - 1];
            }

            if (T[i] == T[j])
            {
                j++;
            }
            p[i] = j;
        }
        return p;
    }

    #endregion

    #region Naive String Matching

    public static int NaiveStringMatching(char[] T, char[] P)
    {
        int n = T.Length;
        int m = P.Length;

        for (int s = 0; s <= n - m; s++)
        {
            bool match = true;
            for (int k = 0; k < m; k++)
            {
                if (P[k] != T[s + k])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                return s;
            }
        }

        return -1;
    }

    #endregion
}

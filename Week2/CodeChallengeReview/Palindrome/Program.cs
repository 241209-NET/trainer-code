/*
You are given a single string, and it is your job to figure out if that string is a palindrome. A palindrome is a number or word that are the same forwards and backwards (with exact upper/lower casing).

The checkForPalindrome() method takes in 1 argument:
s - the string that you are checking to see if it's a palindrome
Once you've determined whether or not the string is a palindrome, return either true or false.


                            EXPECTED OUTPUT
Happy Birthday!	            false
RACECAR	                    true
amanaplanacanalpanama       true
Saippuakivikauppias	        false
*/

namespace Palindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome3("Happy Birthday!") ? "true" : "false");
        Console.WriteLine(IsPalindrome3("RACECAR") ? "true" : "false");
        Console.WriteLine(IsPalindrome3("amanaplanacanalpanama") ? "true" : "false");
        Console.WriteLine(IsPalindrome3("Saippuakivikauppias") ? "true" : "false");
    }

    public static bool IsPalindrome(string s)
    {
        //build a reverse of the string s and then check for equality
        string revS = "";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            revS += s[i];
        }

        return revS.Equals(s);
    }

    public static bool IsPalindrome2(string s)
    {
        //Making new char array then reversing it
        char[] cArr = s.ToCharArray();
        Array.Reverse(cArr);
        string c = new(cArr);
        return c.Equals(s);
    }

    public static bool IsPalindrome3(string s)
    {
        //Check 1st and last character and move in each time.
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            if(s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}

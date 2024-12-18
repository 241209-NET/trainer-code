/*
You are tasked to convert a string into a secret code. Convert letters (ignoring case) and other characters into a secret code using the following rules:

A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7
All other letters or characters are represented with a '?' in the secret code.

The createSecretCode() method takes in 1 argument:
s - the string that will be converted into the secret code string
Once you've created the secret code version of the string, return the secret code string.


                        EXPECTED OUTPUT
FACE		            6135
Coding	                3?4??7
Feed		            6554
This is a sentence	    ????????1??5??5?35
Cab!		            312?
*/

namespace SecretCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SecretCode3("FACE"));
        Console.WriteLine(SecretCode3("Coding"));
        Console.WriteLine(SecretCode3("Feed"));
        Console.WriteLine(SecretCode3("This is a sentence"));
        Console.WriteLine(SecretCode3("Cab!"));
    }

    static string SecretCode(string s)
    {
        //Check every character in s and add to code
        string code = "";

        s = s.ToUpper();

        //if else chain
        foreach(char c in s)
        {
            if(c == 'A') code += "1";
            else if(c == 'B') code += "2";
            else if(c == 'C') code += "3";
            else if(c == 'D') code += "4";
            else if(c == 'E') code += "5";
            else if(c == 'F') code += "6";
            else if(c == 'G') code += "7";
            else code += "?";
        }

        return code;
    }

    static string SecretCode2(string s)
    {
        throw new NotImplementedException();
        //See above except use switch statement

        //Another way is to use a dictionary
    }

    static string SecretCode3(string s)
    {
        //Try using ASCII table        
        string code = "";

        s = s.ToUpper();

        foreach(char c in s)
        {
            if(c >= 'A' && c <= 'G') code += c - 'A' + 1;
            else code += '?';
        }
        return code;
    }
}

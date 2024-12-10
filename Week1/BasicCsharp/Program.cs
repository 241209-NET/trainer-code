namespace BasicCsharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string input = Console.ReadLine() ?? "Hello";

        /*
        string? input = Console.ReadLine();
        if(input == null) input = "Hello";
        */

        Console.WriteLine(input?.Trim());

        //Whole Numbers
        int n1 = 0; //32 bit
        long l1 = 0L; //64 bit
        short s1 = 0; //16 bit
        byte b1 = 0; //8 bit

        //Floating point number eg has decimal
        double radius = 8.8; //64 bit
        float dist = 9.654F; //32 bit

        //Characters & Boolean
        char c1 = 'y';
        char c2 = '.';

        bool isRaining = false;

        //string
        string myString = "Hello, welcome to C# basics";

        //Arithmetic Operators
        int myNumber = 1 + 1;
        myNumber = 45 - 16;
        myNumber = 4 * 86;
        myNumber = 46 / 7;
        myNumber = 97 % 2; //returns the remainder

        //Comparison Operators
        bool checking = (myNumber == n1);
        checking = (myNumber != n1);
        checking = (myNumber > n1); //6 > 6
        checking = (myNumber < n1); // 6 < 6
        checking = (myNumber >= n1);
        checking = (myNumber <= n1);

        //Logical Operators
        bool check2 = (checking && isRaining); 
        check2 = (checking || isRaining); 
        check2 = (!checking);

        //Look up bitwise operators

        //Assignment Operators
        int num = 6; //num is 6
        num = 7; //num is 7
        num += 3; //num is 10, num = num + 3
        num -= 5; //num is 5, num = num - 5
        num *= 5; //num = num * 5
        num /= 5; //num = num / 5
    }
}

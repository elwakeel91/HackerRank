// URL of the problem
// https://www.hackerrank.com/challenges/strong-password/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    // Return the minimum number of characters to make the password strong
    static int minimumNumber(int n, string password)
    {
        // Variables holding our character types
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";

        // Variable holding the minimum length of our password and character types
        int minLength = 6;
        int characterType = 4;
        int requiredLength = 0;
        bool isNumber = false;
        bool isLowerCase = false;
        bool isUpperCase = false;
        bool isSpecialCharacter = false;

        // Loop through the characters in the password
        for (int i = 0; i < password.Length; i++)
        {
            // Check if the password contains a number
            if (numbers.Contains(password[i]))
                isNumber = true;

            // Check if the password contains a lower case letter
            if (lower_case.Contains(password[i]))
                isLowerCase = true;

            // Check if the password contains an upper case letter
            if (upper_case.Contains(password[i]))
                isUpperCase = true;

            // Check if the password contains a special character
            if (special_characters.Contains(password[i]))
                isSpecialCharacter = true;
        }

        // There is a number
        if (isNumber)
            characterType--;

        // There is a lower case letter
        if (isLowerCase)
            characterType--;

        // There is an upper case letter
        if (isUpperCase)
            characterType--;

        // There is a special character
        if (isSpecialCharacter)
            characterType--;

        // Find the remaining length needed for the password length
        minLength -= password.Length;

        // Set the required length as the greater between remaining length needed and the number of character types needed
        requiredLength = minLength > characterType ? minLength : characterType;

        // Return the required length
        return (requiredLength);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string password = Console.ReadLine();
        int answer = minimumNumber(n, password);
        Console.WriteLine(answer);
    }
}

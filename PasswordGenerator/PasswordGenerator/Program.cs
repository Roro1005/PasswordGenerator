﻿using System;
using PasswordGenerator;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            var rand = new System.Random();
            int digits = Functions.ParseArgs(args);

            char[] bigLetters = new char[]
            {
                'A','B','C','D','E','F','G','H','I','J','K',
                'L','M','N','O','P','Q','R','S','T','U','V',
                'W','X','Y','Z'
            };
            char[] littleLetters = new char[]
            {
                'a','b','c','d','e','f','g','h','i','j','k',
                'l','m','n','o','p','q','r','s','t','u','v',
                'w','x','y','z'
            };
            char[] numberLetters = new char[]
            {
                '0','1','2','3','4','5','6','7','8','9'
            };
            char[] markLetters = new char[]
            {
                '-','_','!','+','*','#','$','%','&',
            };

            string result = "";
            for(int i =0;i< 10;i++)
            {
                char letter=Functions.GetRandomletter
                    (bigLetters, littleLetters,numberLetters,rand);

                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}

﻿namespace Character_Sequence
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char latter = text[i];
                Console.WriteLine(latter);
            }
        }
    }
}
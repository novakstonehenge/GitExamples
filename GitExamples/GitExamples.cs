﻿using System;

namespace GitExamples
{
    public class GitExamples
    {
        public static int Main(string[] args)
        {
            Person[] persons = {
                new Person("Chromik Daniel"),
                new Person("Cacek Filip"),
                new Person("Novak Zdenek"),
                new Person("Hercka Lubos"),
                new Person("Biza Martin"),
                new Person("Bulicka Michal")
            };

            for(byte i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i]);
            }

            return 0;
        }
    }
}

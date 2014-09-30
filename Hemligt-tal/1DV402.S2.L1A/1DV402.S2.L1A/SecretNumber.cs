﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        private int _number;
        private int _count;
        public const int MaxNumberOfGuesses = 7;
        Random rnd = new Random(); // Creates a new Random, called rnd.

        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
           _count = 0;
           _number = rnd.Next(1, 101); // Gives _number a random integer between 1 and 100.

        }

        public bool MakeGuess(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt! Gissa på något högre.\n Du har {1} gissningar kvar.", number, _count);
                return false;
            }
            if (number > _number)
            {
                Console.WriteLine("{0} är för högt! Gissa på något lägre.\n Du har {1} gissningar kvar.", number, _count);
                return false;
            }

            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Tyvärr, du har slut på gissningar!\n Det hemliga talet var {0}.", _number);
                throw new ApplicationException();
            }

            if(number == _number)
            {
                Console.WriteLine("Grattis! Du gissade rätt på {0} försök.", _count);
                return true;
            }
            _count++;
            return false;
        }

    }

}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSWU_.NET_camp
{
    internal class Pair
    {
        private int number;
        private int freq;



        public Pair(int number, int freq)
        {
            this.Number = number;
            this.Freq = freq;

        }

        public int Number { get => number; set => number = value; }
        public int Freq { get => freq; set => freq = value; }

        public override string ToString()
        {
            return $"{number} - {freq} ";
        }

    }
}

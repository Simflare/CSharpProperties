﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{
    class TimePeriod
    {
        private int days;
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine(time.Days);
            time.Days = 5;
            Console.WriteLine(time.Days);
            Console.ReadLine();
        }
    }
}

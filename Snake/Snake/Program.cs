﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Snake s = new Snake();
            while (true)
            {
                s.dibujar();
                s.moverse();
            }
        }
    }
}

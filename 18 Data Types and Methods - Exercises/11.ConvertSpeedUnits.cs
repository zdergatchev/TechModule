﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;

            float kmSpeed = (distance / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distance / 1609.0f) / hourTime;

            Console.WriteLine(metersSpeed);
            Console.WriteLine(kmSpeed);
            Console.WriteLine(milesSpeed);
        }
    }
}

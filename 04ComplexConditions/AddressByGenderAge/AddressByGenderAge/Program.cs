﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressByGenderAge
{
	class Program
	{
		static void Main(string[] args)
		{
			var age = double.Parse(Console.ReadLine());
			var gender = Console.ReadLine();

			if (age >= 16)
			{
				if (gender == "m")
				{
					Console.WriteLine("Mr.");
				}
				else
				{
					Console.WriteLine("Ms.");
				}
			}
			else
			{
				if (gender == "m")
				{
					Console.WriteLine("Master");
				}
				else
				{
					Console.WriteLine("Miss");
				}

			}


		}
	}
}

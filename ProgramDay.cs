using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int dayno;

			dayno = Convert.ToInt32(Console.ReadLine());

			switch (dayno)
			{
				case 1:
					Console.Write("Monday");
					break;
				case 2:
					Console.Write("Tuesday");
					break;
				case 3:
					Console.Write("Wednesday");
					break;
				case 4:
					Console.Write("Thursday");
					break;
				case 5:
					Console.Write("Friday");
					break;
				case 6:
					Console.Write("Saturday");
					break;
				case 7:
					Console.Write("Sunday");
					break;
				default:
					Console.Write("Invalid day number. \nPlease try again ....\n");
					break;
			}
					Console.ReadKey();
			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 0;
            age = Math.Round(age);
            byte Gender = 0;
            switch (Gender)
            {
                case 0:
                    if (age <= 0 || age < 60 || age > 150)
                    {
                        Console.WriteLine("Не проходит");
                    }
                    else
                    {
                        Console.WriteLine("Проходит");
                    }
                    break;

                case 1:
                    if (age <= 0 || age < 65 || age > 150)
                    {
                        Console.WriteLine("Не проходит");
                    }
                    else
                    {
                        Console.WriteLine("Проходит");
                    }
                    break;
            }

        }
    }
}

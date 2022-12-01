using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode_2022.Solutions
{
    internal class day1
    {
        public void solution1()
        {
            int mostCalories = 0;
            int calories = 0;

            string[] lines = File.ReadAllLines("../../../Input/Day1.txt");

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (calories > mostCalories)
                    {
                        mostCalories = calories;
                    }
                    calories = 0;
                    continue;
                }

                calories += int.Parse(line);
            }

            Console.WriteLine("Solution: {0}", mostCalories);
        }

        public void solution2()
        {
            List<int> elfs = new List<int>();
            int calories = 0;

            string[] lines = File.ReadAllLines("../../../Input/Day1.txt");

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    elfs.Add(calories);
                    calories = 0;
                    continue;
                }

                calories += int.Parse(line);
            }

            elfs.Sort();
            elfs.Reverse();

            Console.WriteLine("Solution: {0}", elfs[0] + elfs[1] + elfs[2]);
        }
    }
}

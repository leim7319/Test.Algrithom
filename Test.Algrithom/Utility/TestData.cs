using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Algrithom.Utility
{
    public class TestData
    {
        public static List<int> GetListFromString()
        {
            string str = BuildString(10000);
            List<int> result = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            return result;
        }

        public static string BuildString(int length)
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;
            while (i <= length)
            {
                sb.Append(i);
                sb.AppendLine();
                i++;
            }

            return sb.ToString();
        }


        public static List<int> GetRandom(int count, int minValue, int maxValue)
        {
            List<int> result = new List<int>();
            Random rand = new Random();
            int i = 1;
            int temp = 0;
            while (i <= count)
            {
                temp = rand.Next(minValue, maxValue);
                result.Add(temp);
                i++;

                Console.WriteLine(temp);
            }

            return result;
        }
    }
}

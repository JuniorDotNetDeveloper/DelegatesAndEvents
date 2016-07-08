using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Linq
    {
        public void QueryMehtod()
        {
            int[] numbers = new int[] { 1, 2, 7, 9, 11, 19 };
            Func<int, bool> predicate = x =>
            {
                Console.WriteLine("Bingo");
                return x * x > x + x;
            };

            var result1 = numbers.Where(x => x > 10);
            var result2 = result1.Where(x => predicate(x));

            foreach (var r in result2)
                Console.WriteLine(r);
        }
    }
}

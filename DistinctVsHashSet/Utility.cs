using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistinctVsHashSet
{
    public class Utility
    {
        public static List<int> ListWithDuplicates()
        {
            var list = new List<int>();

            list.AddRange(Enumerable.Range(0, 10000));
            list.AddRange(Enumerable.Range(0, 10000));
            list.AddRange(Enumerable.Range(2000, 10000));
            list.AddRange(Enumerable.Range(0, 10000));
            list.AddRange(Enumerable.Range(0, 10000));
            list.AddRange(Enumerable.Range(0, 1000));
            list.AddRange(Enumerable.Range(5000, 10000));
            list.AddRange(Enumerable.Range(500, 1000));

            return list;
        }
    }
}
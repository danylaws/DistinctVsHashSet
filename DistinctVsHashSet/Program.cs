using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctVsHashSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);

            //Console.WriteLine(Utility.ListWithDuplicates().Count());

            //Console.WriteLine(Utility.ListWithDuplicates().Distinct().Count());

            //Console.WriteLine(new HashSet<int>(Utility.ListWithDuplicates()).Count());

            Console.ReadKey();
        }

        [MemoryDiagnoser]
        public class DistinctVsHashSet
        {
            [Benchmark]
            public List<int> WithDistinct()
            {
                var list = Utility.ListWithDuplicates();

                var distinct = list.Distinct().ToList();

                return distinct;
            }

            [Benchmark]
            public List<int> WithHashSet()
            {
                var list = Utility.ListWithDuplicates();

                var hashset = new HashSet<int>(list).ToList();

                return hashset;
            }
        }
    }
}
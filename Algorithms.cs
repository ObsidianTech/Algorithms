using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Algoritms
{
    public class Tests
    {
        private Stopwatch _stopwatch;
        private TimeResult _timeResult;
        [SetUp]
        public void Setup()
        {
            _stopwatch = new Stopwatch();
            _timeResult = new TimeResult();
        }

        [Test]
        public void FindPairWithGivenSum() //O(n^2)
        {
            int[] arr = new[] {8, 7, 2, 5, 3, 1};
            int a = 0;
            int b = 0;
            
            _stopwatch.Start();

            foreach (var item in arr)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (item + arr[j] == 10)
                    {
                        a = item;
                        b = arr[j];
                    }
                }
            }
            
            _stopwatch.Stop();
            _timeResult.GetTimeResult(_stopwatch);
            
            Assert.AreEqual(10, a + b);
        }

        [Test]
        public void FindPairWithGivenPairAfterSorting() //O(nlog(n))
        {   
            int[] arr = new[] {8, 7, 2, 5, 3, 1};
            int a = 0;
            int b = 0;
            
            _stopwatch.Start();
            
            Array.Sort(arr);

            var low = 0;
            var high = arr.Length - 1;
            
            while (low < high)
            {
                if (arr[low] + arr[high] == 10)
                {
                    a = arr[low];
                    b = arr[high];
                }

                if (arr[low] + arr[high] < 10)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            
            _stopwatch.Stop();
            _timeResult.GetTimeResult(_stopwatch);
            
            Assert.AreEqual(10, a + b);
        }
    }
}
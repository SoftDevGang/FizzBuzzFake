using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzFake
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            string expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
            Assert.AreEqual(expected, FizzBuzz.Print(20));
        }
    }

    public class FizzBuzz
    {
        public static string Print(int top)
        {
            var parts = Enumerable.Range(1, top).Select(n => Convert(n)).ToArray();
            return String.Join(",",parts);
        }

        private static string Convert(int input)
        {
            if (input % 15 == 0)
            {
                return "FizzBuzz";

            } if (input % 3 == 0)
            {
                return "Fizz";

            } if (input % 5 == 0)
            {
                return  "Buzz";
                
            }
            return "" + input;
        }
    }
}

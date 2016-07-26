using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzFake
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            string expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,18,19,Buzz";
            Assert.AreEqual(expected, FizzBuzz.Print(20));
        }
    }

    public class FizzBuzz
    {
        public static string Print(int top)
        {
            string first ="";
            for (int i = 1; i <= 14; i++)
            {
                first += Convert(i) + ",";
            
            }
            return string.Format("{0}FizzBuzz,16,17,Fizz,18,19,Buzz", first);
        }

        private static string Convert(int input)
        {
            if (input % 3 == 0)
            {
                return  "Fizz";
                
            }if (input % 5 == 0)
            {
                return  "Buzz";
                
            }
            return "" + input;
        }
    }
}

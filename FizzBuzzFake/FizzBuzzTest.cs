﻿using System;
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
            Assert.AreEqual(expected. FizzBuzz.print(20));
        }
    }
}

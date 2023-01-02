using NUnit.Framework;
using System;

namespace Password_Helper.Test
{
    public class MainTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestNumber()
        {

        }

        [Test]
        public void TestString()
        {

        }

        [Test]
        public void TestAll()
        {

        }

        [Test]
        [Repeat(100)]
        public void TestPattern()
        {
            Password ps = new Password();

            //var data = new string[] { "LettersUpper:5", "lettersLower:8", "number:5", "character:3" };
            //var run = ps.Pattern("LettersUpper:5,lettersLower:8,number:5,character:3");
            //Assert.That(data, Is.EqualTo(run));

            var ptn = ps.Pattern("number:2,lettersLower:2,LettersUpper:3,character:3").ToString();
            Console.WriteLine(ptn);
        }

    }
}
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
        [Repeat(50)]
        public void TestPattern()
        {
            Password ps = new Password();

            //var data = new string[] { "LettersUpper:5", "lettersLower:8", "number:5", "character:3" };
            //var run = ps.Pattern("LettersUpper:5,lettersLower:8,number:5,character:3");
            //Assert.That(data, Is.EqualTo(run));

            var ptn = ps.Pattern("number:2,lettersLower:2,LettersUpper:4,number:2,character:1").ToString();
            Console.WriteLine(ptn);
        }

        [Test]
        [Repeat(50)]
        public void TestGet()
        {

        }

    }
}
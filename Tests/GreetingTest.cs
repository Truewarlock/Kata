using NUnit.Framework;
using Seminar1.ProductionCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.Tests
{
    [TestFixture]
    class GreetingTest
    {
        Greeting greeting = new Greeting();

        public string[] GenerateName(string par)
        {
            string[] test = { "kek" };
            test[0] = par;
            return test;
        }

        public void ExecuteTest(string[] name, string expected)
        {
            //Arrange

            //Act
            string result = greeting.Greet(name);
            //Assert
            Console.WriteLine(result);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ShouldGreetBob()
        {
            ExecuteTest(GenerateName("Bob"), "Hello, Bob.");
        }
        [Test]
        public void ShouldHandleNull()
        {

            ExecuteTest(null, "Hello, my friend.");
        }
        [Test]
        public void ShouldGreetGigi()
        {

            ExecuteTest(GenerateName("Gigi"), "Hello, Gigi.");
        }
        [Test]
        public void ShouldHandleShouting()
        {

            ExecuteTest(GenerateName("JERRY"), "HELLO, JERRY!");
        }
        [Test]
        public void ShoulHanndleTwo() {

            string[] test = { "Jill", "Jane" };
            ExecuteTest(test,"Hello, Jill and Jane");
        }

        [Test]
        public void ShoulHanddleMultiple()
        {
            string[] test = { "Amy", "Brian", "Charlotte" };
            ExecuteTest(test, "Hello, Amy, Brian and Charlotte");
        }
        [Test]
        public void ShoulHanddleMultipleAndShouting()
        {
            string[] test = { "Amy", "BRIAN", "Charlotte" };
            ExecuteTest(test, "Hello, Amy and Charlotte. AND BRIAN!");
        }



    }
}

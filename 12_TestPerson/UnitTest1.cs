using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12_TestPerson
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //Arrange
            PersonRepository repo = new PersonRepository();
            Person realPerson = new Person();
            //ACT   -Using our methods
            repo.AddPerson(realPerson);
            List<Person> returnList = repo.ReturnPerson();
            //ASSERT
            int expected = 1;
            int actual = returnList.Count();

            Assert.AreEqual(expected, actual);


            
        }
    }
}

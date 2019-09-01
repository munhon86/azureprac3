using System;
using Xunit;
using simplePrac.Controllers;

namespace simplePrac.test
{
    
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnMyName() 
        {
            var returnVal = controller.Get(1);//"Hi";
            Assert.Equal("value", returnVal.Value);
        }
        
        [Fact]
        public void Test1()
        {
            string test = "Test";
            Assert.Equal("Test", test);
        }
    }
}

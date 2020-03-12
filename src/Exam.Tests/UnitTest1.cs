using System;
using Xunit;

namespace Exam.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var date = new DateTime(2010,1,1) ;
            var item = new TodoItem(date, "ça", new TestClock(new DateTime(2010,1,2)));
            
            Assert.Equal(item.Age.Days, 1);
        }
    }
}

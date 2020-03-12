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
            var item = new TodoItem(date, "ça");
            TodoItem.DateProvider = new DateTime(2010,1,2);

            Assert.Same(item.Age.Days, 1);
        }
    }
}

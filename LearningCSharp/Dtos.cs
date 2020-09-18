using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Dtos
    {
        [Fact]
        public void DoingThem()
        {
            AddCustomer(new CreateCustomer { First = "Bob", Last = "Smith", MI = "T" });

        }
        public void AddCustomer(CreateCustomer customerToAdd)
        {

        }
        public class CreateCustomer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string MI { get; set; }

        }
    }
}

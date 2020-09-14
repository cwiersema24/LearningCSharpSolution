using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class DeclaringVariables
    {
        [Fact]
        public void DeclaringAVariables()
        {
            int age;
            string name;
            age = 23;
            name = "Nate";

            Assert.Equal("Nate", name);
            Assert.Equal(23, age);
        }

        [Fact]
        public void InitualizingVariables()
        {
            int age = 42;
            string name = "Dale";

            int a = 10, b = 20;

            decimal pay = 42.32M;

            char mi = 'M';

            var herAge = 52;
        }

        [Fact]
        public void ValueTypesExample()
        {
            int x = 10;
            int y = x;

            x = 30;
            Assert.Equal(10, y);
        }
        [Fact]
        public void ReferenceTypeExample()
        {
            Dog x = new Dog() { Name = "Fido" };
            //alias to same object
            Dog y = x;
            y.Name = "Rover";

            Assert.Equal("Rover", x.Name);
        }

        [Fact]
        public void StringsAreReferencesThatWorkLikeValuesForAssignmemnts()
        {
            string x = "Fido";
            string y = x;

            y = "Rover";

            Assert.Equal("Fido", x);
        }
        [Fact]
        public void OtherThingsAboutStrings()
        {
            var myName = "cora";
            var otherName = myName.ToUpper();
            Assert.Equal("cora", myName);
            Assert.Equal("CORA", otherName);

            string lotsOfNumbers = "";
            for (var t =0; t<100; t++)
            {
                lotsOfNumbers += t + ",";

            }

        }
        [Fact]
        public void ForBuildingBigStringsUseAStringBuilder()
        {
            StringBuilder builder = new StringBuilder();
            for(var t = 0; t<100; t++)
            {
                builder.Append($"{t},");
            }

            var otherBulder = new StringBuilder("Tacos");
            Assert.Equal("Tacos", otherBulder.ToString());
        }


    }

    public class Dog
    {
        public string Name;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class ByRefAndByVal
    {
        [Fact]
        public void ShowingIt()
        {
            int x = 10, y = 20;
            MessWithThem(ref x, ref y);

            Assert.Equal(20, x);
            Assert.Equal(40, y);
        }
        [Fact]
        public void UsingAnOUtParam()
        {
            
            var fullName = FormatName("Luke", "Skywalker", out int x);
            Assert.Equal("Skywalker, Luke", fullName);
            Assert.Equal(15, x);
        }
        [Fact]
        public void AnExample()
        {
            var age = "51";
            if(int.TryParse(age, out int numberAge))
            {
                Assert.Equal(51, numberAge);
            }
        }
        [Fact]
        public void SwappingThings()
        {
            int x = 1, y = 2;
            Swap(ref x, ref y);
            Assert.Equal(2, x);
            Assert.Equal(1, y);

            string me = "Cora", you = "Jeff";
            Swap(ref me, ref you);
            Assert.Equal("Jeff", me);
            Assert.Equal("Cora", you);
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        public void MessWithThem(ref int a,ref int b)
        {
            a = a * 2;
            b = b * 2;
        }

        public string FormatName (string first, string last, out int count)
        {
            var fullName =  $"{last}, {first}";
            count = fullName.Length;
            return fullName;
        }

         
    }
}

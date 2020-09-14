using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Collections
    {
        [Fact]
        public void MyFavoriteNumbers()
        {
            var myFavNumbers =new ArrayList();
            myFavNumbers.Add(24);
            myFavNumbers.Add(7);
            myFavNumbers.Add(90);

            Assert.Equal(24, myFavNumbers[0]);

            myFavNumbers[1] = 45;
            Assert.Equal(45, myFavNumbers[1]);

            myFavNumbers.Add("Tacos");
            var firstTwo = ((int)myFavNumbers[0]) + ((int)myFavNumbers[1]);
            Assert.Equal(69, firstTwo);

        }

        [Fact]
        public void GenericFavNum()
        {
            var myFavNumbers = new List<int>();
            //"Parametric Polymorphisim"

            myFavNumbers.Add(8);
            myFavNumbers.Add(20);
            myFavNumbers.Add(100);

            var firstTwo = myFavNumbers[0] + myFavNumbers[1];
            Assert.Equal(28, firstTwo);
        }

        [Fact]
        public void InitializingList()
        {
            var favFoods = new List<string> { "Tacos", "Titos", "Pizza" };
            Assert.Equal("Titos", favFoods[1]);
        }

        [Fact]
        public void EnumeratingValesOfAList()
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var total = 0;

           foreach(var numeber in nums)
            {
                total += numeber;
            }

            Assert.Equal(45, total);
            Assert.Equal(45, nums.Sum());


        }

        [Fact]
        public void UningDic()
        {
            var friends = new Dictionary<char, string>
            {
                {'s', "Sean" },
                {'j', "Jessica" }
            };

            friends.Add('d', "David");

            Assert.Equal("Sean", friends['s']);
            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsKey('x'));


            foreach (char key in friends.Keys)
            {

            }

            foreach (string value in friends.Values)
            {

            }
            foreach (KeyValuePair<char,string> kvp in friends)
            {

            }
        }
    }
}

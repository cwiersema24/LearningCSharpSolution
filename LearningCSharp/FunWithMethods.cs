using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class FunWithMethods
    {
        [Fact]
        public void OverloadingMethods()
        {
            var thingy = new Thingy();
            var fullName = thingy.FormatName("Han", "Solo");
            Assert.Equal("Solo, Han", fullName);

            fullName = thingy.FormatName("Han", "Solo", "D");
            Assert.Equal("Solo, Han D.", fullName);

        }

        [Fact]
        public void DefaultsAndParams()
        {
            var thingy = new Thingy();
            Assert.Equal(2, thingy.Add(2, 0));
            Assert.Equal(12, thingy.Add(2));
            Assert.Equal(15, thingy.Add());

            var nums = new int[] { 1, 2, 3 };
            var result = thingy.Add(nums);
            Assert.Equal(6, result);

            result = thingy.Add(10, 15, 20);
            Assert.Equal(45, result);

        }
    }
}

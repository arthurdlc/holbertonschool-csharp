using System;
using System.Collections.Generic;
using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Max_ListWithMultipleValues_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Equal(5, Operations.Max(nums));
        }

        [Fact]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.Equal(0, Operations.Max(nums));
        }

        [Fact]
        public void Max_NullList_ReturnsZero()
        {
            Assert.Equal(0, Operations.Max(null));
        }

        [Fact]
        public void Max_ListWithNegativeValues_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, -20, -30, -5 };
            Assert.Equal(-5, Operations.Max(nums));
        }

        [Fact]
        public void Max_ListWithSingleValue_ReturnsValue()
        {
            List<int> nums = new List<int> { 42 };
            Assert.Equal(42, Operations.Max(nums));
        }
    }
}

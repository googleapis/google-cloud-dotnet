// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using System;
using Xunit;

namespace Google.Common.Tests
{
    public class PreconditionsTest
    {
        const int RangeMin = -4;
        const int RangeMax = 5;

        [Fact]
        public void CheckNotNull_Valid()
        {
            object x = new object();
            Assert.Same(x, x.CheckNotNull(nameof(x)));
        }

        [Fact]
        public void CheckNotNull_Invalid()
        {
            object x = null;
            var exception = Assert.Throws<ArgumentNullException>(() => x.CheckNotNull(nameof(x)));
            Assert.Equal(nameof(x), exception.ParamName);
        }

        [Theory]
        [InlineData(RangeMin)]
        [InlineData((RangeMin + RangeMax) / 2)]
        [InlineData(RangeMax)]
        public void CheckRange_Valid(int value)
        {
            Preconditions.CheckArgumentRange(value, nameof(value), -4, 5); 
        }

        [Theory]
        [InlineData(RangeMin - 1)]
        [InlineData(RangeMax + 1)]
        public void CheckRange_Invalid(int value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Preconditions.CheckArgumentRange(value, nameof(value), -4, 5));
        }

        [Fact]
        public void CheckState_Valid()
        {
            Preconditions.CheckState(true, "Not used");
        }

        [Fact]
        public void CheckState_Invalid()
        {
            string message = "Exception message";
            var exception = Assert.Throws<InvalidOperationException>(() => Preconditions.CheckState(false, message));
            Assert.Equal(message, exception.Message);
        }
    }
}

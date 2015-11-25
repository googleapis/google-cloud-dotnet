// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using NUnit.Framework;
using System;

namespace Google.Common.Tests
{
    public class PreconditionsTest
    {
        const int RangeMin = -4;
        const int RangeMax = 5;

        [Test]
        public void CheckNotNull_Valid()
        {
            object x = new object();
            Assert.AreSame(x, x.CheckNotNull(nameof(x)));
        }

        [Test]
        public void CheckNotNull_Invalid()
        {
            object x = null;
            var exception = Assert.Throws<ArgumentNullException>(() => x.CheckNotNull(nameof(x)));
            Assert.AreEqual(nameof(x), exception.ParamName);
        }

        [Test]
        [TestCase(RangeMin, Description = "Minimum value")]
        [TestCase((RangeMin + RangeMax) / 2, Description = "Non-boundary value")]
        [TestCase(RangeMax, Description = "Maximum value")]
        public void CheckRange_Valid(int value)
        {
            Preconditions.CheckArgumentRange(value, nameof(value), -4, 5); 
        }

        [Test]
        [TestCase(RangeMin - 1)]
        [TestCase(RangeMax + 1)]
        public void CheckRange_Invalid(int value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Preconditions.CheckArgumentRange(value, nameof(value), -4, 5));
        }

        [Test]
        public void CheckState_Valid()
        {
            Preconditions.CheckState(true, "Not used");
        }

        [Test]
        public void CheckState_Invalid()
        {
            string message = "Exception message";
            var exception = Assert.Throws<InvalidOperationException>(() => Preconditions.CheckState(true, message));
            Assert.AreEqual(message, exception.Message);
        }
    }
}

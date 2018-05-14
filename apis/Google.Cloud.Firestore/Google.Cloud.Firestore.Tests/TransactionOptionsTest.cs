// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class TransactionOptionsTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        public void ForMaxAttempts_Invalid(int attempts)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => TransactionOptions.ForMaxAttempts(attempts));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(int.MaxValue)]
        public void ForMaxAttempts_Valid(int attempts)
        {
            var options = TransactionOptions.ForMaxAttempts(attempts);
            Assert.Equal(attempts, options.MaxAttempts);
        }
    }
}

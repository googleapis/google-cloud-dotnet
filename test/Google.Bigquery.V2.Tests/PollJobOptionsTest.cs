// Copyright 2016 Google Inc. All Rights Reserved.
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

namespace Google.Bigquery.V2.Tests
{
    public class PollJobOptionsTest
    {
        [Fact]
        public void NoOptionsSet()
        {
            var options = new PollJobOptions();
            options.Validate();
            Assert.Null(options.GetEffectiveDeadline());
        }

        [Fact]
        public void Deadline()
        {
            var deadline = new DateTimeOffset(2016, 6, 19, 2, 3, 4, TimeSpan.FromHours(1));
            var options = new PollJobOptions { Deadline = deadline };
            options.Validate();
            Assert.Equal(deadline, options.GetEffectiveDeadline());
        }

        [Fact]
        public void Timeout()
        {
            var timeout = TimeSpan.FromDays(2);
            var options = new PollJobOptions { Timeout = timeout };
            var now = DateTime.UtcNow;
            var effectiveDeadline = options.GetEffectiveDeadline();
            var tolerance = TimeSpan.FromSeconds(1);
            Assert.InRange(effectiveDeadline.Value, now + timeout - tolerance, now + timeout + tolerance);
        }

        [Fact]
        public void DeadlineAndTimeout()
        {
            var options = new PollJobOptions
            {
                Deadline = DateTimeOffset.UtcNow,
                Timeout = TimeSpan.FromDays(1)
            };
            Assert.Throws<ArgumentException>(() => options.Validate());
        }
    }
}

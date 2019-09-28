// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using System;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class SessionPoolOptionsTests
    {
        public static TheoryData<string, object> ValidPropertyValues = new TheoryData<string, object>
        {
            { nameof(SessionPoolOptions.IdleSessionRefreshDelay), TimeSpan.FromSeconds(1) },
            { nameof(SessionPoolOptions.MaintenanceLoopDelay), TimeSpan.FromSeconds(0) },
            { nameof(SessionPoolOptions.MaximumActiveSessions), 1 },
            { nameof(SessionPoolOptions.MaximumConcurrentSessionCreates), 5 },
            { nameof(SessionPoolOptions.CreateSessionMaximumBatchSize), 10 },
            { nameof(SessionPoolOptions.MinimumPooledSessions), 0 },
            { nameof(SessionPoolOptions.PoolEvictionDelay), TimeSpan.FromSeconds(1) },
            { nameof(SessionPoolOptions.SessionEvictionJitter), RetrySettings.NoJitter },
            { nameof(SessionPoolOptions.SessionRefreshJitter), RetrySettings.NoJitter },
            { nameof(SessionPoolOptions.WaitOnResourcesExhausted), ResourcesExhaustedBehavior.Fail },
            { nameof(SessionPoolOptions.WriteSessionsFraction), 0.5 }
        };

        public static TheoryData<string, object> InvalidPropertyValues = new TheoryData<string, object>
        {
            { nameof(SessionPoolOptions.IdleSessionRefreshDelay), TimeSpan.FromSeconds(0) },
            { nameof(SessionPoolOptions.MaintenanceLoopDelay), TimeSpan.FromSeconds(-1) },
            { nameof(SessionPoolOptions.MaximumActiveSessions), 0 },
            { nameof(SessionPoolOptions.MaximumConcurrentSessionCreates), 0 },
            { nameof(SessionPoolOptions.CreateSessionMaximumBatchSize), 0 },
            { nameof(SessionPoolOptions.MinimumPooledSessions), -1 },
            { nameof(SessionPoolOptions.PoolEvictionDelay), TimeSpan.FromSeconds(0) },
            { nameof(SessionPoolOptions.SessionEvictionJitter), null },
            { nameof(SessionPoolOptions.SessionRefreshJitter), null },
            { nameof(SessionPoolOptions.WaitOnResourcesExhausted), (ResourcesExhaustedBehavior) 10 },
            { nameof(SessionPoolOptions.WriteSessionsFraction), -0.1 },
            { nameof(SessionPoolOptions.WriteSessionsFraction), 1.1 },
        };

        [Theory]
        [MemberData(nameof(ValidPropertyValues))]
        public void ValidProperties(string propertyName, object value)
        {
            SetProperty(propertyName, value);
        }

        [Theory]
        [MemberData(nameof(InvalidPropertyValues))]
        public void InvalidProperties(string propertyName, object value)
        {
            Assert.ThrowsAny<ArgumentException>(() => SetProperty(propertyName, value));
        }

        private static void SetProperty(string propertyName, object value)
        {
            var options = new SessionPoolOptions();
            var property = typeof(SessionPoolOptions).GetTypeInfo().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            try
            {
                property.SetValue(options, value);
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}

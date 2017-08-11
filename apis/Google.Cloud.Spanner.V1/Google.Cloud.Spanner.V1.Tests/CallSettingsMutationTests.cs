// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class CallSettingsMutationTests
    {
        // ReSharper disable once UnusedParameter.Local
        public CallSettingsMutationTests(ITestOutputHelper outputHelper)
        {
            //Uncomment these lines to debug a specific test.
//            TestLogger.TestOutputHelper = outputHelper;
//            TestLogger.Install();
//            Logger.LogLevel = V1.Logging.LogLevel.Debug;
        }

        [Fact]
        public void ChangeTimeout()
        {
            // The value itself is pass thru, so we don't test validation
            // on it -- only that it is applied.
            var newTimeoutSeconds = 5;
            var modifiedSettings = SpannerSettings.GetDefault()
                .BeginTransactionSettings.WithCallExpiration(SpannerSettings.GetDefault().ConvertTimeoutToExpiration(newTimeoutSeconds));
            Assert.NotNull(modifiedSettings.Timing.Retry.TotalExpiration.Timeout);
            Assert.Equal(newTimeoutSeconds, modifiedSettings.Timing.Retry.TotalExpiration.Timeout.Value.TotalSeconds);

            modifiedSettings = SpannerSettings.GetDefault()
                .ExecuteSqlStreamSettings.WithCallExpiration(SpannerSettings.GetDefault().ConvertTimeoutToExpiration(newTimeoutSeconds));
            Assert.NotNull(modifiedSettings.Timing.Expiration.Timeout);
            Assert.Equal(newTimeoutSeconds, modifiedSettings.Timing.Expiration.Timeout.Value.TotalSeconds);
        }

        [Fact]
        public void ChangeTimeoutZero()
        {
            var targetSettings = SpannerSettings.GetDefault().Clone();
            targetSettings.AllowImmediateTimeouts = true;

            var modifiedSettings = targetSettings
                .BeginTransactionSettings.WithCallExpiration(targetSettings.ConvertTimeoutToExpiration(0));
            Assert.NotNull(modifiedSettings.Timing.Retry.TotalExpiration.Timeout);
            Assert.Equal(0, modifiedSettings.Timing.Retry.TotalExpiration.Timeout.Value.TotalSeconds);

            targetSettings.AllowImmediateTimeouts = false;
            modifiedSettings = targetSettings
                .BeginTransactionSettings.WithCallExpiration(targetSettings.ConvertTimeoutToExpiration(0));
            Assert.NotNull(modifiedSettings.Timing.Retry.TotalExpiration);
            Assert.Equal(Expiration.None, modifiedSettings.Timing.Retry.TotalExpiration);
        }


        [Fact]
        public void CloneSpannerSettings()
        {
            var originalSettings = SpannerSettings.GetDefault().Clone();

            // This simple test ensure we havent missed a property in our Clone.
            // It first acquires new values for each property.
            // There are some asserts that will fail if the new value chosen is not different.
            // Then it ensures the cloned value is equal to the original (that all properties were properly
            // cloned).
            var newSettings = TypeDescriptor.GetProperties(originalSettings).Cast<PropertyDescriptor>()
                .ToDictionary<PropertyDescriptor, PropertyDescriptor, object>(x => x, x =>
                {
                    if (x.PropertyType == typeof(CallSettings))
                    {
                        return CallSettings.FromCallTiming(CallTiming.FromTimeout(TimeSpan.FromSeconds(7)));
                    }
                    if (x.PropertyType == typeof(IClock))
                    {
                        return new Mock<IClock>().Object;
                    }
                    if (x.PropertyType == typeof(IScheduler))
                    {
                        return new Mock<IScheduler>().Object;
                    }

                    if (!x.PropertyType.GetTypeInfo().IsValueType)
                    {
                        // If this assert fails, special case the property to generate a different value.
                        Assert.NotNull(x.GetValue(originalSettings));
                        return null;
                    }
                    if (x.PropertyType == typeof(bool))
                    {
                        return !(bool) x.GetValue(originalSettings);
                    }
                    // If this exception throws, special case the property to generate a different value.
                    throw new InvalidOperationException(
                        "Add a Clone() test case handler for the new SpannerSetting type");
                });

            foreach (var kvp in newSettings)
            {
                kvp.Key.SetValue(originalSettings, kvp.Value);
            }

            var clonedSettings = originalSettings.Clone();
            foreach (var kvp in newSettings)
            {
                Assert.Equal(kvp.Key.GetValue(originalSettings), kvp.Key.GetValue(clonedSettings));
            }
        }
    }
}

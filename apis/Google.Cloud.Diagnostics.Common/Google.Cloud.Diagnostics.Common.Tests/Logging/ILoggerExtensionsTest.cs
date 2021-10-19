// Copyright 2021 Google LLC
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

using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ILoggerExtensionsTest
    {
        [Fact]
        public void WithLabels_NoChangesInOriginalLogger()
        {
            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair");

            var originalLogger = loggerMock.Object;
            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            Assert.NotSame(originalLogger, augmentedLogger);
            loggerMock.VerifyNoOtherCalls();

            originalLogger.LogInformation("Cutting hair");

            loggerMock
                .VerifyLog(Times.Once())
                .VerifyNoOtherCalls();
        }

        [Fact]
        public void WithLabels_BeginsScopeAndEndsScope()
        {
            var scopeMock = GetScopeMock();

            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair")
                .SetupBeginScope(scopeMock.Object, new KeyValuePair<string, string>("job_title", "hairdresser"));

            var originalLogger = loggerMock.Object;
            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            augmentedLogger.LogInformation("Cutting hair");

            scopeMock.Verify(scope => scope.Dispose(), Times.Once());
            loggerMock
                .VerifyLog(Times.Once())
                .VerifyBeginScope(Times.Once())
                .VerifyNoOtherCalls();
        }

        [Fact]
        public void WithLabels_UseOriginalAfterAugmented()
        {
            var scopeMock = GetScopeMock();

            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair")
                .SetupBeginScope(scopeMock.Object, new KeyValuePair<string, string>("job_title", "hairdresser"));

            var originalLogger = loggerMock.Object;
            var augmentedLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            augmentedLogger.LogInformation("Cutting hair");
            scopeMock.Verify(scope => scope.Dispose(), Times.Once());
            originalLogger.LogInformation("Cutting hair");

            loggerMock
                .VerifyLog(Times.Exactly(2))
                .VerifyBeginScope(Times.Once())
                .VerifyNoOtherCalls();
        }

        [Fact]
        public void WithAddedLabels()
        {
            var scopeMock = GetScopeMock();

            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair")
                .SetupBeginScope(scopeMock.Object,
                    new KeyValuePair<string, string>("job_title", "hairdresser"),
                    new KeyValuePair<string, string>("tool", "scissors"));

            var originalLogger = loggerMock.Object;
            var oneLabelLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            var twoLabelLogger = oneLabelLogger.WithAddedLabels(new KeyValuePair<string, string>("tool", "scissors"));

            Assert.NotSame(oneLabelLogger, twoLabelLogger);

            twoLabelLogger.LogInformation("Cutting hair");

            scopeMock.Verify(scope => scope.Dispose(), Times.Once());

            loggerMock
                .VerifyLog(Times.Once())
                .VerifyBeginScope(Times.Once())
                .VerifyNoOtherCalls();
        }

        [Fact]
        public void WithAddedLabels_NoWithLabels()
        {
            var scopeMock = GetScopeMock();

            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair")
                .SetupBeginScope(scopeMock.Object, new KeyValuePair<string, string>("job_title", "hairdresser"));

            var originalLogger = loggerMock.Object;
            var augmentedLogger = originalLogger.WithAddedLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));

            augmentedLogger.LogInformation("Cutting hair");

            scopeMock.Verify(scope => scope.Dispose(), Times.Once());
            loggerMock
                .VerifyLog(Times.Once())
                .VerifyBeginScope(Times.Once())
                .VerifyNoOtherCalls();
        }

        [Fact]
        public void WithAddedLabels_UseInitiallyAugmented()
        {
            var oneLabelScopeMock = GetScopeMock();
            var twoLabelsScopeMock = GetScopeMock();

            var loggerMock = new Mock<ILogger>(MockBehavior.Strict)
                .SetupLog("Cutting hair")
                .SetupBeginScope(oneLabelScopeMock.Object, new KeyValuePair<string, string>("job_title", "hairdresser"))
                .SetupBeginScope(twoLabelsScopeMock.Object,
                    new KeyValuePair<string, string>("job_title", "hairdresser"),
                    new KeyValuePair<string, string>("tool", "scissors"));

            var originalLogger = loggerMock.Object;
            var oneLabelLogger = originalLogger.WithLabels(new KeyValuePair<string, string>("job_title", "hairdresser"));
            var twoLabelLogger = oneLabelLogger.WithAddedLabels(new KeyValuePair<string, string>("tool", "scissors"));

            twoLabelLogger.LogInformation("Cutting hair");

            oneLabelScopeMock.Verify(scope => scope.Dispose(), Times.Never());
            twoLabelsScopeMock.Verify(scope => scope.Dispose(), Times.Once());

            oneLabelLogger.LogInformation("Cutting hair");

            oneLabelScopeMock.Verify(scope => scope.Dispose(), Times.Once());
            twoLabelsScopeMock.Verify(scope => scope.Dispose(), Times.Once());

            loggerMock
                .VerifyLog(Times.Exactly(2))
                .VerifyBeginScope(Times.Exactly(2))
                .VerifyNoOtherCalls();
        }

        private Mock<IDisposable> GetScopeMock()
        {
            var scopeMock = new Mock<IDisposable>(MockBehavior.Strict);
            scopeMock.Setup(scope => scope.Dispose());
            return scopeMock;
        }
    }

    public static class ILoggerMockExtensions
    {
        public static Mock<ILogger> SetupBeginScope(this Mock<ILogger> loggerMock, IDisposable returnValue, params KeyValuePair<string, string>[] acceptedLabels)
        {
            loggerMock
            .Setup(logger => logger.BeginScope(
                It.Is<LabellingScopeState>(state => state.Labels.Count == acceptedLabels.Length && !state.Labels.Except(acceptedLabels).Any())))
            .Returns(returnValue);

            return loggerMock;
        }

        public static Mock<ILogger> SetupLog(this Mock<ILogger> loggerMock, string expectedFinalMessage)
        {
            loggerMock
                .Setup(logger => logger.Log(It.IsAny<LogLevel>(), It.IsAny<EventId>(), It.IsAny<object>(), It.IsAny<Exception>(), It.IsAny<Func<object, Exception, string>>()))
                .Callback<LogLevel, EventId, object, Exception, Func<object, Exception, string>>((level, eventId, state, exception, formatter) => Assert.Equal(expectedFinalMessage, formatter(state, exception)));

            return loggerMock;
        }

        public static Mock<ILogger> VerifyBeginScope(this Mock<ILogger> loggerMock, Times times)
        {
            loggerMock.Verify(logger => logger.BeginScope(It.IsAny<object>()), times);

            return loggerMock;
        }

        public static Mock<ILogger> VerifyLog(this Mock<ILogger> loggerMock, Times times)
        {
            loggerMock.Verify(logger => logger.Log(It.IsAny<LogLevel>(), It.IsAny<EventId>(), It.IsAny<object>(), null, It.IsAny<Func<object, Exception, string>>()), times);
            return loggerMock;
        }
    }
}

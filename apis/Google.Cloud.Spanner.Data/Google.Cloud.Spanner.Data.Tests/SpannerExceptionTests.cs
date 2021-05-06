// Copyright 2021 Google Inc. All Rights Reserved.
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

using Grpc.Core;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerExceptionTests
    {
        [InlineData(ErrorCode.InvalidArgument, "Invalid argument", false)]
        [InlineData(ErrorCode.Aborted, "Transaction aborted", true)]
        [InlineData(ErrorCode.Unknown, "An unknown error occurred", false)]
        [InlineData(ErrorCode.Unknown, "Transaction outcome unknown", true)]
        [Theory]
        public void IsRetryableWithErrorCodeAndMessage(ErrorCode errorCode, string message, bool isRetryable)
        {
            Assert.Equal(isRetryable, new SpannerException(errorCode, message).IsRetryable);
        }

        [InlineData(StatusCode.InvalidArgument, "Invalid argument", false)]
        [InlineData(StatusCode.Aborted, "Transaction aborted", true)]
        [InlineData(StatusCode.Unknown, "An unknown error occurred", false)]
        [InlineData(StatusCode.Unknown, "Transaction outcome unknown", true)]
        [Theory]
        public void IsRetryableWithInnerException(StatusCode statusCode, string message, bool isRetryable)
        {
            Assert.Equal(isRetryable, new SpannerException(new RpcException(new Status(statusCode, message))).IsRetryable);
        }

        [InlineData(ErrorCode.InvalidArgument, StatusCode.InvalidArgument, "Invalid argument", false)]
        [InlineData(ErrorCode.Aborted, StatusCode.Aborted, "Transaction aborted", true)]
        [InlineData(ErrorCode.Unknown, StatusCode.Unknown, "An unknown error occurred", false)]
        [InlineData(ErrorCode.Unknown, StatusCode.Unknown, "Transaction outcome unknown", true)]
        [Theory]
        public void IsRetryableWithErrorCodeAndInnerException(ErrorCode errorCode, StatusCode statusCode, string message, bool isRetryable)
        {
            Assert.Equal(isRetryable, new SpannerException(errorCode, new RpcException(new Status(statusCode, message))).IsRetryable);
        }
    }
}

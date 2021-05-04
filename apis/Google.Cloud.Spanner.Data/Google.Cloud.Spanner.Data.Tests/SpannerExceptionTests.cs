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
        [Fact]
        public void IsRetryable()
        {
            Assert.False(new SpannerException(ErrorCode.InvalidArgument, "Invalid argument").IsRetryable);
            Assert.False(new SpannerException(ErrorCode.InvalidArgument, new RpcException(new Status(StatusCode.InvalidArgument, "Invalid argument"))).IsRetryable);
            Assert.False(new SpannerException(new RpcException(new Status(StatusCode.InvalidArgument, "Invalid argument"))).IsRetryable);
            Assert.True(new SpannerException(ErrorCode.Aborted, "Transaction aborted").IsRetryable);
            Assert.True(new SpannerException(ErrorCode.Aborted, new RpcException(new Status(StatusCode.Aborted, "Transaction aborted"))).IsRetryable);
            Assert.True(new SpannerException(new RpcException(new Status(StatusCode.Aborted, "Transaction aborted"))).IsRetryable);
            Assert.False(new SpannerException(ErrorCode.Unknown, "An unknown error occurred").IsRetryable);
            Assert.False(new SpannerException(ErrorCode.Unknown, new RpcException(new Status(StatusCode.Unknown, "An unknown error occurred"))).IsRetryable);
            Assert.False(new SpannerException(new RpcException(new Status(StatusCode.Unknown, "An unknown error occurred"))).IsRetryable);
            Assert.True(new SpannerException(ErrorCode.Unknown, "Transaction outcome unknown.").IsRetryable);
            Assert.True(new SpannerException(ErrorCode.Unknown, new RpcException(new Status(StatusCode.Unknown, "Transaction outcome unknown."))).IsRetryable);
            Assert.True(new SpannerException(new RpcException(new Status(StatusCode.Unknown, "Transaction outcome unknown."))).IsRetryable);
        }

    }
}

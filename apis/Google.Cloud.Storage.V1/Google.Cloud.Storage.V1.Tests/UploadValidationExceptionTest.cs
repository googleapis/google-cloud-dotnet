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
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.Tests
{
    public class UploadValidationExceptionTest
    {
        [Fact]
        public void Construction_NoAdditionalFailure()
        {
            var ex = new UploadValidationException("hash", new Object(), null);
            Assert.Null(ex.AdditionalFailures);
        }

        [Fact]
        public void Construction_WithAdditionalFailure()
        {
            var additional = new Exception();
            var ex = new UploadValidationException("hash", new Object(), new AggregateException(additional));
            Assert.Same(additional, ex.AdditionalFailures.InnerExceptions[0]);
        }

        [Fact]
        public void Construction_WithAdditionalFailure_Empty()
        {
            Assert.Throws<ArgumentException>(() => new UploadValidationException("hash", new Object(), new AggregateException("No inner exceptions")));
        }
    }
}

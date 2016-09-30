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
using System.Linq;

namespace Google.Cloud.Vision.V1
{
    public partial class BatchAnnotateImagesResponse
    {
        /// <summary>
        /// If the <see cref="AnnotateImageResponse.Error"/> property is non-null for any response within <see cref="Responses"/>,
        /// throws an <see cref="AggregateException"/>, containing one <see cref="AnnotateImageException"/>
        /// for each failed response. Otherwise, returns <c>this</c> (so that the method can be called in a fluent manner).
        /// </summary>
        /// <exception cref="AggregateException">The <see cref="AnnotateImageResponse.Error"/> property is non-null on one or
        /// more element of <see cref="Responses"/>.</exception>
        /// <returns><c>this</c> if no responses contain errors.</returns>
        public BatchAnnotateImagesResponse ThrowOnAnyError()
        {
            var failedResponses = Responses.Where(r => r.Error != null);
            if (failedResponses.Any())
            {
                throw new AggregateException("At least one annotation response contained an error",
                    failedResponses.Select(r => new AnnotateImageException(r)));
            }
            return this;
        }
    }
}

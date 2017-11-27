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

namespace Google.Cloud.VideoIntelligence.V1
{
    public partial class AnnotateVideoResponse
    {
        /// <summary>
        /// If the <see cref="VideoAnnotationResults.Error"/> property is non-null for any response within <see cref="AnnotationResults"/>,
        /// throws an <see cref="AggregateException"/>, containing one <see cref="AnnotateVideoException"/>
        /// for each failed response. Otherwise, returns <c>this</c> (so that the method can be called in a fluent manner).
        /// </summary>
        /// <exception cref="AggregateException">The <see cref="VideoAnnotationResults.Error"/> property is non-null on one or
        /// more element of <see cref="AnnotationResults"/>.</exception>
        /// <returns><c>this</c> if no responses contain errors.</returns>
        public AnnotateVideoResponse ThrowOnAnyError()
        {
            var failedResults = AnnotationResults.Where(r => r.Error != null);
            if (failedResults.Any())
            {
                throw new AggregateException("At least one annotation result contained an error",
                    failedResults.Select(r => new AnnotateVideoException(r)));
            }
            return this;
        }
    }
}

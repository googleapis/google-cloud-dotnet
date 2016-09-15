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

namespace Google.Cloud.Vision.V1
{
    public partial class BatchAnnotateImagesResponse
    {
        /// <summary>
        /// If the <see cref="Error"/> property is non-null for any response within <see cref="Responses"/>,
        /// throws an <see cref="AnnotateImageException"/>.
        /// Otherwise, returns <c>this</c> (so that the method can be called in a fluent manner).
        /// </summary>
        /// <remarks>
        /// If there are multiple failed responses, an error is only generated for the first one.
        /// </remarks>
        /// <exception cref="AnnotateImageException">The <see cref="Error"/> property is non-null on one or
        /// more element of <see cref="Responses"/>.</exception>
        /// <returns><c>this</c> if no responses contain errors.</returns>
        public BatchAnnotateImagesResponse ThrowOnAnyError()
        {
            foreach (var response in Responses)
            {
                response.ThrowOnError();
            }
            return this;
        }
    }
}

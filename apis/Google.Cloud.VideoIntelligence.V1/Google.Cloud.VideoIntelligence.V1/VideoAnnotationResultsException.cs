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

using Google.Api.Gax;
using System;

namespace Google.Cloud.VideoIntelligence.V1
{
    /// <summary>
    /// An error occurring when annotating an video.
    /// </summary>
    public sealed class VideoAnnotationResultsException : Exception
    {
        /// <summary>
        /// The complete response containing the error.
        /// </summary>
        public VideoAnnotationResults Response { get; }

        /// <summary>
        /// Constructs an exception based on the error in <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response containing the error. Must not be null, and the <see cref="VideoAnnotationResults.Error"/>
        /// property must not be null.</param>
        public VideoAnnotationResultsException(VideoAnnotationResults response) : base(CheckHasError(response).Error.Message)
        {
            this.Response = response;
        }

        // Annoying, but GaxPreconditions.CheckArgument doesn't return anything, because it doesn't have the whole argument.
        // Maybe we should have an overload for that. (It's only really a problem in constructor chaining...)
        private static VideoAnnotationResults CheckHasError(VideoAnnotationResults response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            GaxPreconditions.CheckArgument(response.Error != null, nameof(response), "response must contain an error");
            return response;
        }
    }
}

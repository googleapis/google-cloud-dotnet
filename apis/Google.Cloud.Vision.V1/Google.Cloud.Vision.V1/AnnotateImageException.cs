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

using Google.Api.Gax;
using System;

namespace Google.Cloud.Vision.V1
{
    /// <summary>
    /// An error occurring when annotating an image.
    /// </summary>
    public sealed class AnnotateImageException : Exception
    {
        /// <summary>
        /// The complete response containing the error.
        /// </summary>
        public AnnotateImageResponse Response { get; }

        /// <summary>
        /// Constructs an exception based on the error in <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response containing the error. Must not be null, and the <see cref="AnnotateImageResponse.Error"/>
        /// property must not be null.</param>
        public AnnotateImageException(AnnotateImageResponse response) : base(response?.Error?.Message)
        {
            // The null-conditional operator in the constructor initializer make it okay 
            GaxPreconditions.CheckNotNull(response, nameof(response));
            GaxPreconditions.CheckArgument(response.Error != null, nameof(response), "response must contain an error");
            Response = response;
        }
    }
}

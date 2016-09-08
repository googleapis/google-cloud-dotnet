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
using Google.Protobuf.Collections;
using System.Collections;
using System.Collections.Generic;

namespace Google.Cloud.Vision.V1
{
    // TODO: For a single image detecting a single annotation type, will there ever be an error *and* results?
    // Should we actually just throw an exception?

    /// <summary>
    /// The annotations associated with a single annotation type (such as faces, or landmarks)
    /// from one image, along with any error status returned as part of the response.
    /// Any annotations returned are valid, even if an error message is present.
    /// </summary>
    /// <typeparam name="T">The type of annotation returned.</typeparam>
    public sealed class AnnotationResult<T> : IReadOnlyList<T>
    {
        private readonly RepeatedField<T> annotations;

        /// <summary>
        /// The error status in the response, or <c>null</c> if the call was successful.
        /// </summary>
        public Rpc.Status Error { get; }

        // Implementation note: it would be nice to accept an IReadOnlyList<T> here, but
        // RepeatedField doesn't implement that :( See https://github.com/google/protobuf/issues/2041

        /// <summary>
        /// Constructs an instance from the given error (which may be null) and annotations.
        /// </summary>
        /// <param name="error">Error to record. May be null.</param>
        /// <param name="annotations">Annotations in the response. Must not be null.</param>
        public AnnotationResult(Rpc.Status error, RepeatedField<T> annotations)
        {
            GaxPreconditions.CheckNotNull(annotations, nameof(annotations));
            Error = error;
            this.annotations = annotations;
        }

        /// <inheritdoc />
        public T this[int index] => annotations[index];

        /// <inheritdoc />
        public int Count => annotations.Count;

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator() => annotations.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

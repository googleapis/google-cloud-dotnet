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
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Optional configuration to be used when starting a span.
    /// </summary>
    public sealed class StartSpanOptions
    {
        /// <summary>Gets the span kind.</summary>
        public SpanKind SpanKind { get; }

        /// <summary>Gets the labels to be added to the span.</summary>
        public Dictionary<string, string> Labels { get; }

        private StartSpanOptions(SpanKind spanKind, Dictionary<string, string> labels)
        {
            SpanKind = GaxPreconditions.CheckEnumValue(spanKind, nameof(spanKind));
            Labels = GaxPreconditions.CheckNotNull(labels, nameof(labels));
        }

        /// <summary>
        /// Creates a <see cref="StartSpanOptions"/>.
        /// </summary>
        /// <param name="spanKind">Optional, the span kind.  Defaults to <see cref="SpanKind.Unspecified"/></param>
        /// <param name="labels">Optional, labels to add to the span.</param>
        public static StartSpanOptions Create(
            SpanKind spanKind = SpanKind.Unspecified, Dictionary<string, string> labels = null)
                => new StartSpanOptions(spanKind, labels ?? new Dictionary<string, string>());
    }
}
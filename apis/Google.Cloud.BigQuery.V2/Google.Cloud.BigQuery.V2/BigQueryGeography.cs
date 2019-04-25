// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Representation of the BigQuery GEOGRAPHY type, representing geospatial information.
    /// Equality is determined on a simple textual basis.
    /// </summary>
    public sealed class BigQueryGeography : IEquatable<BigQueryGeography>
    {
        /// <summary>
        /// The text of the vector geometry, in WKT (Well-known Text) format.
        /// </summary>
        public string Text { get; }

        private BigQueryGeography(string text) =>
            Text = GaxPreconditions.CheckNotNull(text, nameof(text));

        /// <summary>
        /// Creates a BigQueryGeography object based on the given text.
        /// </summary>
        /// <remarks>
        /// Currently, this method will accept any non-null string reference. In the future it
        /// may perform genuine parsing of the Well-Known Text format.
        /// </remarks>
        /// <param name="text">Text to parse. Must not be null.</param>
        /// <returns>A BigQueryGeography with the specified text.</returns>
        public static BigQueryGeography Parse(string text) => new BigQueryGeography(text);

        /// <summary>
        /// Returns a hash code for this object.
        /// </summary>
        /// <returns>A hash code for this object.</returns>
        public override int GetHashCode() => Text.GetHashCode();

        /// <summary>
        /// Compares this value with <paramref name="obj"/> for equality.
        /// </summary>
        /// <param name="obj">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="obj"/> is an equal <see cref="BigQueryGeography"/> value; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj) => Equals(obj as BigQueryGeography);


        /// <summary>
        /// Compares this value with <paramref name="other"/> for equality.
        /// </summary>
        /// <param name="other">The value to compare with this one.</param>
        /// <returns><c>true</c> if <paramref name="other"/> is an equal <see cref="BigQueryGeography"/> value; <c>false</c> otherwise.</returns>
        public bool Equals(BigQueryGeography other) => other?.Text == Text;

        /// <summary>
        /// Returns the textual representation of this value.
        /// </summary>
        /// <returns>The textual representation of this value</returns>
        public override string ToString() => Text;

    }
}

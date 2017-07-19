// Copyright 2017, Google Inc. All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Dlp.V2Beta1
{
    /// <summary>
    /// Resource name for the 'result' resource.
    /// </summary>
    public sealed partial class ResultName : IResourceName, IEquatable<ResultName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("inspect/results/{result}");

        /// <summary>
        /// Parses the given result resource name in string form into a new
        /// <see cref="ResultName"/> instance.
        /// </summary>
        /// <param name="resultName">The result resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResultName"/> if successful.</returns>
        public static ResultName Parse(string resultName)
        {
            GaxPreconditions.CheckNotNull(resultName, nameof(resultName));
            TemplatedResourceName resourceName = s_template.ParseName(resultName);
            return new ResultName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given result resource name in string form into a new
        /// <see cref="ResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="resultName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="resultName">The result resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ResultName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resultName, out ResultName result)
        {
            GaxPreconditions.CheckNotNull(resultName, nameof(resultName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(resultName, out resourceName))
            {
                result = new ResultName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ResultName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="resultId">The result ID. Must not be <c>null</c>.</param>
        public ResultName(string resultId)
        {
            ResultId = GaxPreconditions.CheckNotNull(resultId, nameof(resultId));
        }

        /// <summary>
        /// The result ID. Never <c>null</c>.
        /// </summary>
        public string ResultId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ResultId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ResultName);

        /// <inheritdoc />
        public bool Equals(ResultName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ResultName a, ResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ResultName a, ResultName b) => !(a == b);
    }


    public partial class InspectOperationResult
    {
        /// <summary>
        /// <see cref="ResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ResultName ResultName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta1.ResultName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInspectFindingsRequest
    {
        /// <summary>
        /// <see cref="ResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ResultName ResultName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta1.ResultName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataLabeling.V1Beta1;
using sys = System;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    /// <summary>Resource name for the <c>Instruction</c> resource.</summary>
    public sealed partial class InstructionName : gax::IResourceName, sys::IEquatable<InstructionName>
    {
        /// <summary>The possible contents of <see cref="InstructionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/instructions/{instruction}</c>.</summary>
            ProjectInstruction = 1,
        }

        private static gax::PathTemplate s_projectInstruction = new gax::PathTemplate("projects/{project}/instructions/{instruction}");

        /// <summary>Creates a <see cref="InstructionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstructionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstructionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstructionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstructionName"/> with the pattern <c>projects/{project}/instructions/{instruction}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instructionId">The <c>Instruction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstructionName"/> constructed from the provided ids.</returns>
        public static InstructionName FromProjectInstruction(string projectId, string instructionId) =>
            new InstructionName(ResourceNameType.ProjectInstruction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instructionId: gax::GaxPreconditions.CheckNotNullOrEmpty(instructionId, nameof(instructionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstructionName"/> with pattern
        /// <c>projects/{project}/instructions/{instruction}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instructionId">The <c>Instruction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstructionName"/> with pattern
        /// <c>projects/{project}/instructions/{instruction}</c>.
        /// </returns>
        public static string Format(string projectId, string instructionId) =>
            FormatProjectInstruction(projectId, instructionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstructionName"/> with pattern
        /// <c>projects/{project}/instructions/{instruction}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instructionId">The <c>Instruction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstructionName"/> with pattern
        /// <c>projects/{project}/instructions/{instruction}</c>.
        /// </returns>
        public static string FormatProjectInstruction(string projectId, string instructionId) =>
            s_projectInstruction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instructionId, nameof(instructionId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstructionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instructions/{instruction}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instructionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstructionName"/> if successful.</returns>
        public static InstructionName Parse(string instructionName) => Parse(instructionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstructionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instructions/{instruction}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instructionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstructionName"/> if successful.</returns>
        public static InstructionName Parse(string instructionName, bool allowUnparsed) =>
            TryParse(instructionName, allowUnparsed, out InstructionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstructionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instructions/{instruction}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instructionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstructionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instructionName, out InstructionName result) =>
            TryParse(instructionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstructionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instructions/{instruction}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instructionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstructionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instructionName, bool allowUnparsed, out InstructionName result)
        {
            gax::GaxPreconditions.CheckNotNull(instructionName, nameof(instructionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstruction.TryParseName(instructionName, out resourceName))
            {
                result = FromProjectInstruction(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instructionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstructionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instructionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstructionId = instructionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstructionName"/> class from the component parts of pattern
        /// <c>projects/{project}/instructions/{instruction}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instructionId">The <c>Instruction</c> ID. Must not be <c>null</c> or empty.</param>
        public InstructionName(string projectId, string instructionId) : this(ResourceNameType.ProjectInstruction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instructionId: gax::GaxPreconditions.CheckNotNullOrEmpty(instructionId, nameof(instructionId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Instruction</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstructionId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstruction: return s_projectInstruction.Expand(ProjectId, InstructionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstructionName);

        /// <inheritdoc/>
        public bool Equals(InstructionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InstructionName a, InstructionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InstructionName a, InstructionName b) => !(a == b);
    }

    public partial class Instruction
    {
        /// <summary>
        /// <see cref="gcdv::InstructionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InstructionName InstructionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InstructionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

// Copyright 2024 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>TestCase</c> resource.</summary>
    public sealed partial class TestCaseName : gax::IResourceName, sys::IEquatable<TestCaseName>
    {
        /// <summary>The possible contents of <see cref="TestCaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
            /// </summary>
            ProjectLocationAgentTestCase = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentTestCase = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}");

        /// <summary>Creates a <see cref="TestCaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TestCaseName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TestCaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TestCaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TestCaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TestCaseName"/> constructed from the provided ids.</returns>
        public static TestCaseName FromProjectLocationAgentTestCase(string projectId, string locationId, string agentId, string testCaseId) =>
            new TestCaseName(ResourceNameType.ProjectLocationAgentTestCase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), testCaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TestCaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TestCaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string testCaseId) =>
            FormatProjectLocationAgentTestCase(projectId, locationId, agentId, testCaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TestCaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TestCaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentTestCase(string projectId, string locationId, string agentId, string testCaseId) =>
            s_projectLocationAgentTestCase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="TestCaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="testCaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TestCaseName"/> if successful.</returns>
        public static TestCaseName Parse(string testCaseName) => Parse(testCaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TestCaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="testCaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TestCaseName"/> if successful.</returns>
        public static TestCaseName Parse(string testCaseName, bool allowUnparsed) =>
            TryParse(testCaseName, allowUnparsed, out TestCaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TestCaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="testCaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TestCaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string testCaseName, out TestCaseName result) => TryParse(testCaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TestCaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="testCaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TestCaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string testCaseName, bool allowUnparsed, out TestCaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(testCaseName, nameof(testCaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentTestCase.TryParseName(testCaseName, out resourceName))
            {
                result = FromProjectLocationAgentTestCase(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(testCaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TestCaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null, string testCaseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
            TestCaseId = testCaseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TestCaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        public TestCaseName(string projectId, string locationId, string agentId, string testCaseId) : this(ResourceNameType.ProjectLocationAgentTestCase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), testCaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TestCase</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TestCaseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentTestCase: return s_projectLocationAgentTestCase.Expand(ProjectId, LocationId, AgentId, TestCaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TestCaseName);

        /// <inheritdoc/>
        public bool Equals(TestCaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TestCaseName a, TestCaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TestCaseName a, TestCaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TestCaseResult</c> resource.</summary>
    public sealed partial class TestCaseResultName : gax::IResourceName, sys::IEquatable<TestCaseResultName>
    {
        /// <summary>The possible contents of <see cref="TestCaseResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
            /// </summary>
            ProjectLocationAgentTestCaseResult = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentTestCaseResult = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}");

        /// <summary>Creates a <see cref="TestCaseResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TestCaseResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TestCaseResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TestCaseResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TestCaseResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resultId">The <c>Result</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TestCaseResultName"/> constructed from the provided ids.</returns>
        public static TestCaseResultName FromProjectLocationAgentTestCaseResult(string projectId, string locationId, string agentId, string testCaseId, string resultId) =>
            new TestCaseResultName(ResourceNameType.ProjectLocationAgentTestCaseResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), testCaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)), resultId: gax::GaxPreconditions.CheckNotNullOrEmpty(resultId, nameof(resultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TestCaseResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resultId">The <c>Result</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TestCaseResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string testCaseId, string resultId) =>
            FormatProjectLocationAgentTestCaseResult(projectId, locationId, agentId, testCaseId, resultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TestCaseResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resultId">The <c>Result</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TestCaseResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentTestCaseResult(string projectId, string locationId, string agentId, string testCaseId, string resultId) =>
            s_projectLocationAgentTestCaseResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resultId, nameof(resultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TestCaseResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="testCaseResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TestCaseResultName"/> if successful.</returns>
        public static TestCaseResultName Parse(string testCaseResultName) => Parse(testCaseResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TestCaseResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="testCaseResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TestCaseResultName"/> if successful.</returns>
        public static TestCaseResultName Parse(string testCaseResultName, bool allowUnparsed) =>
            TryParse(testCaseResultName, allowUnparsed, out TestCaseResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TestCaseResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="testCaseResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TestCaseResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string testCaseResultName, out TestCaseResultName result) =>
            TryParse(testCaseResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TestCaseResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="testCaseResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TestCaseResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string testCaseResultName, bool allowUnparsed, out TestCaseResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(testCaseResultName, nameof(testCaseResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentTestCaseResult.TryParseName(testCaseResultName, out resourceName))
            {
                result = FromProjectLocationAgentTestCaseResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(testCaseResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TestCaseResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null, string resultId = null, string testCaseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
            ResultId = resultId;
            TestCaseId = testCaseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TestCaseResultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}/results/{result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="testCaseId">The <c>TestCase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resultId">The <c>Result</c> ID. Must not be <c>null</c> or empty.</param>
        public TestCaseResultName(string projectId, string locationId, string agentId, string testCaseId, string resultId) : this(ResourceNameType.ProjectLocationAgentTestCaseResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), testCaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(testCaseId, nameof(testCaseId)), resultId: gax::GaxPreconditions.CheckNotNullOrEmpty(resultId, nameof(resultId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Result</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ResultId { get; }

        /// <summary>
        /// The <c>TestCase</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TestCaseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentTestCaseResult: return s_projectLocationAgentTestCaseResult.Expand(ProjectId, LocationId, AgentId, TestCaseId, ResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TestCaseResultName);

        /// <inheritdoc/>
        public bool Equals(TestCaseResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TestCaseResultName a, TestCaseResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TestCaseResultName a, TestCaseResultName b) => !(a == b);
    }

    public partial class TestCase
    {
        /// <summary>
        /// <see cref="gcdcv::TestCaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TestCaseName TestCaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TestCaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TestCaseResult
    {
        /// <summary>
        /// <see cref="gcdcv::TestCaseResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TestCaseResultName TestCaseResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TestCaseResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }
    }

    public partial class TestConfig
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Flow"/> resource name property.</summary>
        public FlowName FlowAsFlowName
        {
            get => string.IsNullOrEmpty(Flow) ? null : FlowName.Parse(Flow, allowUnparsed: true);
            set => Flow = value?.ToString() ?? "";
        }

        /// <summary><see cref="PageName"/>-typed view over the <see cref="Page"/> resource name property.</summary>
        public PageName PageAsPageName
        {
            get => string.IsNullOrEmpty(Page) ? null : PageName.Parse(Page, allowUnparsed: true);
            set => Page = value?.ToString() ?? "";
        }
    }

    public partial class IntentCoverage
    {
        public partial class Types
        {
            public partial class Intent
            {
                /// <summary>
                /// <see cref="IntentName"/>-typed view over the <see cref="Intent_"/> resource name property.
                /// </summary>
                public IntentName Intent_AsIntentName
                {
                    get => string.IsNullOrEmpty(Intent_) ? null : IntentName.Parse(Intent_, allowUnparsed: true);
                    set => Intent_ = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class CalculateCoverageRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Agent"/> resource name property.</summary>
        public AgentName AgentAsAgentName
        {
            get => string.IsNullOrEmpty(Agent) ? null : AgentName.Parse(Agent, allowUnparsed: true);
            set => Agent = value?.ToString() ?? "";
        }
    }

    public partial class CalculateCoverageResponse
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Agent"/> resource name property.</summary>
        public AgentName AgentAsAgentName
        {
            get => string.IsNullOrEmpty(Agent) ? null : AgentName.Parse(Agent, allowUnparsed: true);
            set => Agent = value?.ToString() ?? "";
        }
    }

    public partial class ListTestCasesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteTestCasesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TestCaseName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TestCaseName> TestCaseNames
        {
            get => new gax::ResourceNameList<TestCaseName>(Names, s => string.IsNullOrEmpty(s) ? null : TestCaseName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreateTestCaseRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTestCaseRequest
    {
        /// <summary>
        /// <see cref="gcdcv::TestCaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TestCaseName TestCaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TestCaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunTestCaseRequest
    {
        /// <summary>
        /// <see cref="gcdcv::TestCaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TestCaseName TestCaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TestCaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }
    }

    public partial class BatchRunTestCasesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TestCaseName"/>-typed view over the <see cref="TestCases"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TestCaseName> TestCasesAsTestCaseNames
        {
            get => new gax::ResourceNameList<TestCaseName>(TestCases, s => string.IsNullOrEmpty(s) ? null : TestCaseName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class TestError
    {
        /// <summary>
        /// <see cref="TestCaseName"/>-typed view over the <see cref="TestCase"/> resource name property.
        /// </summary>
        public TestCaseName TestCaseAsTestCaseName
        {
            get => string.IsNullOrEmpty(TestCase) ? null : TestCaseName.Parse(TestCase, allowUnparsed: true);
            set => TestCase = value?.ToString() ?? "";
        }
    }

    public partial class ImportTestCasesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportTestCasesResponse
    {
        /// <summary>
        /// <see cref="TestCaseName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TestCaseName> TestCaseNames
        {
            get => new gax::ResourceNameList<TestCaseName>(Names, s => string.IsNullOrEmpty(s) ? null : TestCaseName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ExportTestCasesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListTestCaseResultsRequest
    {
        /// <summary>
        /// <see cref="TestCaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TestCaseName ParentAsTestCaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TestCaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTestCaseResultRequest
    {
        /// <summary>
        /// <see cref="gcdcv::TestCaseResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TestCaseResultName TestCaseResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TestCaseResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

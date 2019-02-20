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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxres = Google.Api.Gax.ResourceNames;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Irm.V1Alpha2
{
    /// <summary>
    /// Resource name for the 'annotation' resource.
    /// </summary>
    public sealed partial class AnnotationName : gax::IResourceName, sys::IEquatable<AnnotationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}/annotations/{annotation}");

        /// <summary>
        /// Parses the given annotation resource name in string form into a new
        /// <see cref="AnnotationName"/> instance.
        /// </summary>
        /// <param name="annotationName">The annotation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotationName"/> if successful.</returns>
        public static AnnotationName Parse(string annotationName)
        {
            gax::GaxPreconditions.CheckNotNull(annotationName, nameof(annotationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(annotationName);
            return new AnnotationName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given annotation resource name in string form into a new
        /// <see cref="AnnotationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="annotationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="annotationName">The annotation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AnnotationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationName, out AnnotationName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotationName, nameof(annotationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(annotationName, out resourceName))
            {
                result = new AnnotationName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AnnotationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        /// <param name="annotationId">The annotation ID. Must not be <c>null</c>.</param>
        public AnnotationName(string projectId, string incidentId, string annotationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
            AnnotationId = gax::GaxPreconditions.CheckNotNull(annotationId, nameof(annotationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <summary>
        /// The annotation ID. Never <c>null</c>.
        /// </summary>
        public string AnnotationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId, AnnotationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AnnotationName);

        /// <inheritdoc />
        public bool Equals(AnnotationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AnnotationName a, AnnotationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AnnotationName a, AnnotationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'artifact' resource.
    /// </summary>
    public sealed partial class ArtifactName : gax::IResourceName, sys::IEquatable<ArtifactName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}/artifacts/{artifact}");

        /// <summary>
        /// Parses the given artifact resource name in string form into a new
        /// <see cref="ArtifactName"/> instance.
        /// </summary>
        /// <param name="artifactName">The artifact resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ArtifactName"/> if successful.</returns>
        public static ArtifactName Parse(string artifactName)
        {
            gax::GaxPreconditions.CheckNotNull(artifactName, nameof(artifactName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(artifactName);
            return new ArtifactName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given artifact resource name in string form into a new
        /// <see cref="ArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="artifactName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="artifactName">The artifact resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ArtifactName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string artifactName, out ArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(artifactName, nameof(artifactName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(artifactName, out resourceName))
            {
                result = new ArtifactName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ArtifactName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        /// <param name="artifactId">The artifact ID. Must not be <c>null</c>.</param>
        public ArtifactName(string projectId, string incidentId, string artifactId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
            ArtifactId = gax::GaxPreconditions.CheckNotNull(artifactId, nameof(artifactId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <summary>
        /// The artifact ID. Never <c>null</c>.
        /// </summary>
        public string ArtifactId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId, ArtifactId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ArtifactName);

        /// <inheritdoc />
        public bool Equals(ArtifactName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ArtifactName a, ArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ArtifactName a, ArtifactName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'incident' resource.
    /// </summary>
    public sealed partial class IncidentName : gax::IResourceName, sys::IEquatable<IncidentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}");

        /// <summary>
        /// Parses the given incident resource name in string form into a new
        /// <see cref="IncidentName"/> instance.
        /// </summary>
        /// <param name="incidentName">The incident resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IncidentName"/> if successful.</returns>
        public static IncidentName Parse(string incidentName)
        {
            gax::GaxPreconditions.CheckNotNull(incidentName, nameof(incidentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(incidentName);
            return new IncidentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given incident resource name in string form into a new
        /// <see cref="IncidentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="incidentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="incidentName">The incident resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="IncidentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string incidentName, out IncidentName result)
        {
            gax::GaxPreconditions.CheckNotNull(incidentName, nameof(incidentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(incidentName, out resourceName))
            {
                result = new IncidentName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="IncidentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        public IncidentName(string projectId, string incidentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as IncidentName);

        /// <inheritdoc />
        public bool Equals(IncidentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(IncidentName a, IncidentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(IncidentName a, IncidentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'role_assignment' resource.
    /// </summary>
    public sealed partial class RoleAssignmentName : gax::IResourceName, sys::IEquatable<RoleAssignmentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}/roleAssignments/{role_assignment}");

        /// <summary>
        /// Parses the given role_assignment resource name in string form into a new
        /// <see cref="RoleAssignmentName"/> instance.
        /// </summary>
        /// <param name="roleAssignmentName">The role_assignment resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RoleAssignmentName"/> if successful.</returns>
        public static RoleAssignmentName Parse(string roleAssignmentName)
        {
            gax::GaxPreconditions.CheckNotNull(roleAssignmentName, nameof(roleAssignmentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(roleAssignmentName);
            return new RoleAssignmentName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given role_assignment resource name in string form into a new
        /// <see cref="RoleAssignmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="roleAssignmentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="roleAssignmentName">The role_assignment resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RoleAssignmentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string roleAssignmentName, out RoleAssignmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(roleAssignmentName, nameof(roleAssignmentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(roleAssignmentName, out resourceName))
            {
                result = new RoleAssignmentName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RoleAssignmentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        /// <param name="roleAssignmentId">The roleAssignment ID. Must not be <c>null</c>.</param>
        public RoleAssignmentName(string projectId, string incidentId, string roleAssignmentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
            RoleAssignmentId = gax::GaxPreconditions.CheckNotNull(roleAssignmentId, nameof(roleAssignmentId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <summary>
        /// The roleAssignment ID. Never <c>null</c>.
        /// </summary>
        public string RoleAssignmentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId, RoleAssignmentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RoleAssignmentName);

        /// <inheritdoc />
        public bool Equals(RoleAssignmentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RoleAssignmentName a, RoleAssignmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RoleAssignmentName a, RoleAssignmentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'signal' resource.
    /// </summary>
    public sealed partial class SignalName : gax::IResourceName, sys::IEquatable<SignalName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/signals/{signal}");

        /// <summary>
        /// Parses the given signal resource name in string form into a new
        /// <see cref="SignalName"/> instance.
        /// </summary>
        /// <param name="signalName">The signal resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SignalName"/> if successful.</returns>
        public static SignalName Parse(string signalName)
        {
            gax::GaxPreconditions.CheckNotNull(signalName, nameof(signalName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(signalName);
            return new SignalName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given signal resource name in string form into a new
        /// <see cref="SignalName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="signalName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="signalName">The signal resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SignalName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string signalName, out SignalName result)
        {
            gax::GaxPreconditions.CheckNotNull(signalName, nameof(signalName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(signalName, out resourceName))
            {
                result = new SignalName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SignalName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="signalId">The signal ID. Must not be <c>null</c>.</param>
        public SignalName(string projectId, string signalId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SignalId = gax::GaxPreconditions.CheckNotNull(signalId, nameof(signalId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The signal ID. Never <c>null</c>.
        /// </summary>
        public string SignalId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SignalId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SignalName);

        /// <inheritdoc />
        public bool Equals(SignalName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SignalName a, SignalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SignalName a, SignalName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'subscription' resource.
    /// </summary>
    public sealed partial class SubscriptionName : gax::IResourceName, sys::IEquatable<SubscriptionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}/subscriptions/{subscription}");

        /// <summary>
        /// Parses the given subscription resource name in string form into a new
        /// <see cref="SubscriptionName"/> instance.
        /// </summary>
        /// <param name="subscriptionName">The subscription resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName)
        {
            gax::GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(subscriptionName);
            return new SubscriptionName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given subscription resource name in string form into a new
        /// <see cref="SubscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="subscriptionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="subscriptionName">The subscription resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SubscriptionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, out SubscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(subscriptionName, out resourceName))
            {
                result = new SubscriptionName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SubscriptionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        /// <param name="subscriptionId">The subscription ID. Must not be <c>null</c>.</param>
        public SubscriptionName(string projectId, string incidentId, string subscriptionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
            SubscriptionId = gax::GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <summary>
        /// The subscription ID. Never <c>null</c>.
        /// </summary>
        public string SubscriptionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId, SubscriptionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SubscriptionName);

        /// <inheritdoc />
        public bool Equals(SubscriptionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SubscriptionName a, SubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SubscriptionName a, SubscriptionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'tag' resource.
    /// </summary>
    public sealed partial class TagName : gax::IResourceName, sys::IEquatable<TagName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/incidents/{incident}/tags/{tag}");

        /// <summary>
        /// Parses the given tag resource name in string form into a new
        /// <see cref="TagName"/> instance.
        /// </summary>
        /// <param name="tagName">The tag resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagName"/> if successful.</returns>
        public static TagName Parse(string tagName)
        {
            gax::GaxPreconditions.CheckNotNull(tagName, nameof(tagName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(tagName);
            return new TagName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given tag resource name in string form into a new
        /// <see cref="TagName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="tagName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="tagName">The tag resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TagName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagName, out TagName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagName, nameof(tagName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(tagName, out resourceName))
            {
                result = new TagName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TagName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="incidentId">The incident ID. Must not be <c>null</c>.</param>
        /// <param name="tagId">The tag ID. Must not be <c>null</c>.</param>
        public TagName(string projectId, string incidentId, string tagId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IncidentId = gax::GaxPreconditions.CheckNotNull(incidentId, nameof(incidentId));
            TagId = gax::GaxPreconditions.CheckNotNull(tagId, nameof(tagId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The incident ID. Never <c>null</c>.
        /// </summary>
        public string IncidentId { get; }

        /// <summary>
        /// The tag ID. Never <c>null</c>.
        /// </summary>
        public string TagId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IncidentId, TagId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TagName);

        /// <inheritdoc />
        public bool Equals(TagName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TagName a, TagName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TagName a, TagName b) => !(a == b);
    }


    public partial class Annotation
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.AnnotationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.AnnotationName AnnotationName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.AnnotationName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Artifact
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.ArtifactName ArtifactName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.ArtifactName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CancelIncidentRoleHandoverRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ConfirmIncidentRoleHandoverRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateAnnotationRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateArtifactRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateIncidentRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateIncidentRoleAssignmentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSignalRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSubscriptionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTagRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteArtifactRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.ArtifactName ArtifactName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.ArtifactName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteIncidentRoleAssignmentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.SubscriptionName SubscriptionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.SubscriptionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTagRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.TagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.TagName TagName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.TagName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ForceIncidentRoleHandoverRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetIncidentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName IncidentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSignalRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.SignalName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.SignalName SignalName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.SignalName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Incident
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName IncidentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class IncidentRoleAssignment
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListAnnotationsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListArtifactsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListIncidentRoleAssignmentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTagsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.IncidentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.IncidentName ParentAsIncidentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Irm.V1Alpha2.IncidentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RequestIncidentRoleHandoverRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.RoleAssignmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.RoleAssignmentName RoleAssignmentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.RoleAssignmentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SearchIncidentsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SearchSignalsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SendShiftHandoffRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Signal
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.SignalName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.SignalName SignalName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.SignalName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Subscription
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.SubscriptionName SubscriptionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.SubscriptionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Tag
    {
        /// <summary>
        /// <see cref="Google.Cloud.Irm.V1Alpha2.TagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Irm.V1Alpha2.TagName TagName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Irm.V1Alpha2.TagName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}
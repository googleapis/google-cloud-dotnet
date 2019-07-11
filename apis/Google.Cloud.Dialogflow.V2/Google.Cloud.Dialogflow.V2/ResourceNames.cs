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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>
    /// Resource name for the 'agent' resource.
    /// </summary>
    public sealed partial class AgentName : gax::IResourceName, sys::IEquatable<AgentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agents/{agent}");

        /// <summary>
        /// Parses the given agent resource name in string form into a new
        /// <see cref="AgentName"/> instance.
        /// </summary>
        /// <param name="agentName">The agent resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentName"/> if successful.</returns>
        public static AgentName Parse(string agentName)
        {
            gax::GaxPreconditions.CheckNotNull(agentName, nameof(agentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(agentName);
            return new AgentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given agent resource name in string form into a new
        /// <see cref="AgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="agentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="agentName">The agent resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AgentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentName, out AgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentName, nameof(agentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(agentName, out resourceName))
            {
                result = new AgentName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AgentName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="agentId">The <c>agent</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AgentName"/>.</returns>
        public static string Format(string projectId, string agentId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(agentId, nameof(agentId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AgentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="agentId">The agent ID. Must not be <c>null</c>.</param>
        public AgentName(string projectId, string agentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            AgentId = gax::GaxPreconditions.CheckNotNull(agentId, nameof(agentId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The agent ID. Never <c>null</c>.
        /// </summary>
        public string AgentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, AgentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AgentName);

        /// <inheritdoc />
        public bool Equals(AgentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AgentName a, AgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AgentName a, AgentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'context' resource.
    /// </summary>
    public sealed partial class ContextName : gax::IResourceName, sys::IEquatable<ContextName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent/sessions/{session}/contexts/{context}");

        /// <summary>
        /// Parses the given context resource name in string form into a new
        /// <see cref="ContextName"/> instance.
        /// </summary>
        /// <param name="contextName">The context resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContextName"/> if successful.</returns>
        public static ContextName Parse(string contextName)
        {
            gax::GaxPreconditions.CheckNotNull(contextName, nameof(contextName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(contextName);
            return new ContextName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given context resource name in string form into a new
        /// <see cref="ContextName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="contextName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="contextName">The context resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ContextName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contextName, out ContextName result)
        {
            gax::GaxPreconditions.CheckNotNull(contextName, nameof(contextName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(contextName, out resourceName))
            {
                result = new ContextName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ContextName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>session</c> ID. Must not be <c>null</c>.</param>
        /// <param name="contextId">The <c>context</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ContextName"/>.</returns>
        public static string Format(string projectId, string sessionId, string contextId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNull(contextId, nameof(contextId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ContextName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The session ID. Must not be <c>null</c>.</param>
        /// <param name="contextId">The context ID. Must not be <c>null</c>.</param>
        public ContextName(string projectId, string sessionId, string contextId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
            ContextId = gax::GaxPreconditions.CheckNotNull(contextId, nameof(contextId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The session ID. Never <c>null</c>.
        /// </summary>
        public string SessionId { get; }

        /// <summary>
        /// The context ID. Never <c>null</c>.
        /// </summary>
        public string ContextId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SessionId, ContextId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ContextName);

        /// <inheritdoc />
        public bool Equals(ContextName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ContextName a, ContextName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ContextName a, ContextName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'entity_type' resource.
    /// </summary>
    public sealed partial class EntityTypeName : gax::IResourceName, sys::IEquatable<EntityTypeName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent/entityTypes/{entity_type}");

        /// <summary>
        /// Parses the given entity_type resource name in string form into a new
        /// <see cref="EntityTypeName"/> instance.
        /// </summary>
        /// <param name="entityTypeName">The entity_type resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntityTypeName"/> if successful.</returns>
        public static EntityTypeName Parse(string entityTypeName)
        {
            gax::GaxPreconditions.CheckNotNull(entityTypeName, nameof(entityTypeName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(entityTypeName);
            return new EntityTypeName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given entity_type resource name in string form into a new
        /// <see cref="EntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="entityTypeName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="entityTypeName">The entity_type resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="EntityTypeName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityTypeName, out EntityTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(entityTypeName, nameof(entityTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(entityTypeName, out resourceName))
            {
                result = new EntityTypeName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="EntityTypeName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="entityTypeId">The <c>entityType</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="EntityTypeName"/>.</returns>
        public static string Format(string projectId, string entityTypeId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="EntityTypeName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="entityTypeId">The entityType ID. Must not be <c>null</c>.</param>
        public EntityTypeName(string projectId, string entityTypeId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            EntityTypeId = gax::GaxPreconditions.CheckNotNull(entityTypeId, nameof(entityTypeId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The entityType ID. Never <c>null</c>.
        /// </summary>
        public string EntityTypeId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, EntityTypeId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as EntityTypeName);

        /// <inheritdoc />
        public bool Equals(EntityTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(EntityTypeName a, EntityTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(EntityTypeName a, EntityTypeName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'intent' resource.
    /// </summary>
    public sealed partial class IntentName : gax::IResourceName, sys::IEquatable<IntentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent/intents/{intent}");

        /// <summary>
        /// Parses the given intent resource name in string form into a new
        /// <see cref="IntentName"/> instance.
        /// </summary>
        /// <param name="intentName">The intent resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IntentName"/> if successful.</returns>
        public static IntentName Parse(string intentName)
        {
            gax::GaxPreconditions.CheckNotNull(intentName, nameof(intentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(intentName);
            return new IntentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given intent resource name in string form into a new
        /// <see cref="IntentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="intentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="intentName">The intent resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="IntentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string intentName, out IntentName result)
        {
            gax::GaxPreconditions.CheckNotNull(intentName, nameof(intentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(intentName, out resourceName))
            {
                result = new IntentName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="IntentName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="intentId">The <c>intent</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="IntentName"/>.</returns>
        public static string Format(string projectId, string intentId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(intentId, nameof(intentId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="IntentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="intentId">The intent ID. Must not be <c>null</c>.</param>
        public IntentName(string projectId, string intentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            IntentId = gax::GaxPreconditions.CheckNotNull(intentId, nameof(intentId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The intent ID. Never <c>null</c>.
        /// </summary>
        public string IntentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, IntentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as IntentName);

        /// <inheritdoc />
        public bool Equals(IntentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(IntentName a, IntentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(IntentName a, IntentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_agent' resource.
    /// </summary>
    public sealed partial class ProjectAgentName : gax::IResourceName, sys::IEquatable<ProjectAgentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent");

        /// <summary>
        /// Parses the given project_agent resource name in string form into a new
        /// <see cref="ProjectAgentName"/> instance.
        /// </summary>
        /// <param name="projectAgentName">The project_agent resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectAgentName"/> if successful.</returns>
        public static ProjectAgentName Parse(string projectAgentName)
        {
            gax::GaxPreconditions.CheckNotNull(projectAgentName, nameof(projectAgentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectAgentName);
            return new ProjectAgentName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project_agent resource name in string form into a new
        /// <see cref="ProjectAgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectAgentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectAgentName">The project_agent resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectAgentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectAgentName, out ProjectAgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectAgentName, nameof(projectAgentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectAgentName, out resourceName))
            {
                result = new ProjectAgentName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectAgentName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectAgentName"/>.</returns>
        public static string Format(string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectAgentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectAgentName(string projectId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectAgentName);

        /// <inheritdoc />
        public bool Equals(ProjectAgentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectAgentName a, ProjectAgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectAgentName a, ProjectAgentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'session' resource.
    /// </summary>
    public sealed partial class SessionName : gax::IResourceName, sys::IEquatable<SessionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent/sessions/{session}");

        /// <summary>
        /// Parses the given session resource name in string form into a new
        /// <see cref="SessionName"/> instance.
        /// </summary>
        /// <param name="sessionName">The session resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sessionName);
            return new SessionName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new
        /// <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sessionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sessionName">The session resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SessionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(sessionName, out resourceName))
            {
                result = new SessionName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SessionName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>session</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SessionName"/>.</returns>
        public static string Format(string projectId, string sessionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SessionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The session ID. Must not be <c>null</c>.</param>
        public SessionName(string projectId, string sessionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The session ID. Never <c>null</c>.
        /// </summary>
        public string SessionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SessionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc />
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'session_entity_type' resource.
    /// </summary>
    public sealed partial class SessionEntityTypeName : gax::IResourceName, sys::IEquatable<SessionEntityTypeName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/agent/sessions/{session}/entityTypes/{entity_type}");

        /// <summary>
        /// Parses the given session_entity_type resource name in string form into a new
        /// <see cref="SessionEntityTypeName"/> instance.
        /// </summary>
        /// <param name="sessionEntityTypeName">The session_entity_type resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionEntityTypeName"/> if successful.</returns>
        public static SessionEntityTypeName Parse(string sessionEntityTypeName)
        {
            gax::GaxPreconditions.CheckNotNull(sessionEntityTypeName, nameof(sessionEntityTypeName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sessionEntityTypeName);
            return new SessionEntityTypeName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session_entity_type resource name in string form into a new
        /// <see cref="SessionEntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sessionEntityTypeName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sessionEntityTypeName">The session_entity_type resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SessionEntityTypeName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionEntityTypeName, out SessionEntityTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionEntityTypeName, nameof(sessionEntityTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(sessionEntityTypeName, out resourceName))
            {
                result = new SessionEntityTypeName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SessionEntityTypeName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>session</c> ID. Must not be <c>null</c>.</param>
        /// <param name="entityTypeId">The <c>entityType</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SessionEntityTypeName"/>.</returns>
        public static string Format(string projectId, string sessionId, string entityTypeId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNull(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SessionEntityTypeName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The session ID. Must not be <c>null</c>.</param>
        /// <param name="entityTypeId">The entityType ID. Must not be <c>null</c>.</param>
        public SessionEntityTypeName(string projectId, string sessionId, string entityTypeId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
            EntityTypeId = gax::GaxPreconditions.CheckNotNull(entityTypeId, nameof(entityTypeId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The session ID. Never <c>null</c>.
        /// </summary>
        public string SessionId { get; }

        /// <summary>
        /// The entityType ID. Never <c>null</c>.
        /// </summary>
        public string EntityTypeId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SessionId, EntityTypeId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SessionEntityTypeName);

        /// <inheritdoc />
        public bool Equals(SessionEntityTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SessionEntityTypeName a, SessionEntityTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SessionEntityTypeName a, SessionEntityTypeName b) => !(a == b);
    }


    public partial class BatchCreateEntitiesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName ParentAsEntityTypeName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchDeleteEntitiesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName ParentAsEntityTypeName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchDeleteEntityTypesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchDeleteIntentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchUpdateEntitiesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName ParentAsEntityTypeName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchUpdateEntityTypesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchUpdateIntentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Context
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ContextName ContextName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.ContextName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateContextRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName ParentAsSessionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateIntentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName ParentAsSessionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteAgentRequest
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

    public partial class DeleteAllContextsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName ParentAsSessionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteContextRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ContextName ContextName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.ContextName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName EntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteIntentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.IntentName IntentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.IntentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionEntityTypeName SessionEntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.SessionEntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DetectIntentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class EntityType
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName EntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExportAgentRequest
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

    public partial class GetAgentRequest
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

    public partial class GetContextRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ContextName ContextName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.ContextName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.EntityTypeName EntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.EntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetIntentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.IntentName IntentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.IntentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSessionEntityTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionEntityTypeName SessionEntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.SessionEntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ImportAgentRequest
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

    public partial class Intent
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.IntentName IntentName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.IntentName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListContextsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName ParentAsSessionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListEntityTypesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListIntentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.ProjectAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.ProjectAgentName ParentAsProjectAgentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.ProjectAgentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSessionEntityTypesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionName ParentAsSessionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dialogflow.V2.SessionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RestoreAgentRequest
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

    public partial class SearchAgentsRequest
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

    public partial class SessionEntityType
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dialogflow.V2.SessionEntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dialogflow.V2.SessionEntityTypeName SessionEntityTypeName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dialogflow.V2.SessionEntityTypeName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TrainAgentRequest
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

}
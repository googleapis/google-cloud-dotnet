// Copyright 2026 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>GoldengateConnection</c> resource.</summary>
    public sealed partial class GoldengateConnectionName : gax::IResourceName, sys::IEquatable<GoldengateConnectionName>
    {
        /// <summary>The possible contents of <see cref="GoldengateConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
            /// </summary>
            ProjectLocationGoldengateConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationGoldengateConnection = new gax::PathTemplate("projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}");

        /// <summary>Creates a <see cref="GoldengateConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoldengateConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoldengateConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoldengateConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoldengateConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionId">
        /// The <c>GoldengateConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GoldengateConnectionName"/> constructed from the provided ids.
        /// </returns>
        public static GoldengateConnectionName FromProjectLocationGoldengateConnection(string projectId, string locationId, string goldengateConnectionId) =>
            new GoldengateConnectionName(ResourceNameType.ProjectLocationGoldengateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionId, nameof(goldengateConnectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionId">
        /// The <c>GoldengateConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string goldengateConnectionId) =>
            FormatProjectLocationGoldengateConnection(projectId, locationId, goldengateConnectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoldengateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionId">
        /// The <c>GoldengateConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GoldengateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>.
        /// </returns>
        public static string FormatProjectLocationGoldengateConnection(string projectId, string locationId, string goldengateConnectionId) =>
            s_projectLocationGoldengateConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionId, nameof(goldengateConnectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GoldengateConnectionName"/> if successful.</returns>
        public static GoldengateConnectionName Parse(string goldengateConnectionName) =>
            Parse(goldengateConnectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoldengateConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoldengateConnectionName"/> if successful.</returns>
        public static GoldengateConnectionName Parse(string goldengateConnectionName, bool allowUnparsed) =>
            TryParse(goldengateConnectionName, allowUnparsed, out GoldengateConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="goldengateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateConnectionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateConnectionName, out GoldengateConnectionName result) =>
            TryParse(goldengateConnectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoldengateConnectionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="goldengateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoldengateConnectionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string goldengateConnectionName, bool allowUnparsed, out GoldengateConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(goldengateConnectionName, nameof(goldengateConnectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGoldengateConnection.TryParseName(goldengateConnectionName, out resourceName))
            {
                result = FromProjectLocationGoldengateConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(goldengateConnectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoldengateConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string goldengateConnectionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoldengateConnectionId = goldengateConnectionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoldengateConnectionName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goldengateConnectionId">
        /// The <c>GoldengateConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GoldengateConnectionName(string projectId, string locationId, string goldengateConnectionId) : this(ResourceNameType.ProjectLocationGoldengateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), goldengateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(goldengateConnectionId, nameof(goldengateConnectionId)))
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
        /// The <c>GoldengateConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string GoldengateConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationGoldengateConnection: return s_projectLocationGoldengateConnection.Expand(ProjectId, LocationId, GoldengateConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoldengateConnectionName);

        /// <inheritdoc/>
        public bool Equals(GoldengateConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GoldengateConnectionName a, GoldengateConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GoldengateConnectionName a, GoldengateConnectionName b) => !(a == b);
    }

    public partial class GoldengateConnection
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::GoldengateConnectionName GoldengateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbNetworkName"/>-typed view over the <see cref="OdbNetwork"/> resource name property.
        /// </summary>
        public OdbNetworkName OdbNetworkAsOdbNetworkName
        {
            get => string.IsNullOrEmpty(OdbNetwork) ? null : OdbNetworkName.Parse(OdbNetwork, allowUnparsed: true);
            set => OdbNetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbSubnetName"/>-typed view over the <see cref="OdbSubnet"/> resource name property.
        /// </summary>
        public OdbSubnetName OdbSubnetAsOdbSubnetName
        {
            get => string.IsNullOrEmpty(OdbSubnet) ? null : OdbSubnetName.Parse(OdbSubnet, allowUnparsed: true);
            set => OdbSubnet = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateOracleConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateGoldengateConnectionProperties
    {
        /// <summary>
        /// <see cref="GoldengateDeploymentName"/>-typed view over the <see cref="GoldengateDeploymentId"/> resource
        /// name property.
        /// </summary>
        public GoldengateDeploymentName GoldengateDeploymentIdAsGoldengateDeploymentName
        {
            get => string.IsNullOrEmpty(GoldengateDeploymentId) ? null : GoldengateDeploymentName.Parse(GoldengateDeploymentId, allowUnparsed: true);
            set => GoldengateDeploymentId = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateMysqlConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateKafkaConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="TrustStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName TrustStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(TrustStorePasswordSecretVersion) ? null : SecretVersionName.Parse(TrustStorePasswordSecretVersion, allowUnparsed: true);
            set => TrustStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="KeyStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName KeyStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(KeyStorePasswordSecretVersion) ? null : SecretVersionName.Parse(KeyStorePasswordSecretVersion, allowUnparsed: true);
            set => KeyStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SslKeyPasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName SslKeyPasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(SslKeyPasswordSecretVersion) ? null : SecretVersionName.Parse(SslKeyPasswordSecretVersion, allowUnparsed: true);
            set => SslKeyPasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateKafkaSchemaRegistryConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="TrustStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName TrustStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(TrustStorePasswordSecretVersion) ? null : SecretVersionName.Parse(TrustStorePasswordSecretVersion, allowUnparsed: true);
            set => TrustStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="KeyStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName KeyStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(KeyStorePasswordSecretVersion) ? null : SecretVersionName.Parse(KeyStorePasswordSecretVersion, allowUnparsed: true);
            set => KeyStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SslKeyPasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName SslKeyPasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(SslKeyPasswordSecretVersion) ? null : SecretVersionName.Parse(SslKeyPasswordSecretVersion, allowUnparsed: true);
            set => SslKeyPasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateAzureSynapseAnalyticsConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengatePostgresqlConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateMicrosoftSqlserverConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateJavaMessageServiceConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="TrustStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName TrustStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(TrustStorePasswordSecretVersion) ? null : SecretVersionName.Parse(TrustStorePasswordSecretVersion, allowUnparsed: true);
            set => TrustStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="KeyStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName KeyStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(KeyStorePasswordSecretVersion) ? null : SecretVersionName.Parse(KeyStorePasswordSecretVersion, allowUnparsed: true);
            set => KeyStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SslKeyPasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName SslKeyPasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(SslKeyPasswordSecretVersion) ? null : SecretVersionName.Parse(SslKeyPasswordSecretVersion, allowUnparsed: true);
            set => SslKeyPasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateMongodbConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="TlsCertificateKeyFilePasswordSecretVersion"/>
        /// resource name property.
        /// </summary>
        public SecretVersionName TlsCertificateKeyFilePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(TlsCertificateKeyFilePasswordSecretVersion) ? null : SecretVersionName.Parse(TlsCertificateKeyFilePasswordSecretVersion, allowUnparsed: true);
            set => TlsCertificateKeyFilePasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateSnowflakeConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateAmazonRedshiftConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateElasticsearchConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateDb2ConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateRedisConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="TrustStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName TrustStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(TrustStorePasswordSecretVersion) ? null : SecretVersionName.Parse(TrustStorePasswordSecretVersion, allowUnparsed: true);
            set => TrustStorePasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="KeyStorePasswordSecretVersion"/> resource
        /// name property.
        /// </summary>
        public SecretVersionName KeyStorePasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(KeyStorePasswordSecretVersion) ? null : SecretVersionName.Parse(KeyStorePasswordSecretVersion, allowUnparsed: true);
            set => KeyStorePasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GoldengateDatabricksConnectionProperties
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class CreateGoldengateConnectionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGoldengateConnectionRequest
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::GoldengateConnectionName GoldengateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGoldengateConnectionRequest
    {
        /// <summary>
        /// <see cref="gcov::GoldengateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::GoldengateConnectionName GoldengateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::GoldengateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGoldengateConnectionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

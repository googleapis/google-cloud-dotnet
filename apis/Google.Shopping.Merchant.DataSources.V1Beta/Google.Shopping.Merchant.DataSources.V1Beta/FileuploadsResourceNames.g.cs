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
using gsmdv = Google.Shopping.Merchant.DataSources.V1Beta;
using sys = System;

namespace Google.Shopping.Merchant.DataSources.V1Beta
{
    /// <summary>Resource name for the <c>FileUpload</c> resource.</summary>
    public sealed partial class FileUploadName : gax::IResourceName, sys::IEquatable<FileUploadName>
    {
        /// <summary>The possible contents of <see cref="FileUploadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>
            /// .
            /// </summary>
            AccountDatasourceFileupload = 1,
        }

        private static gax::PathTemplate s_accountDatasourceFileupload = new gax::PathTemplate("accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}");

        /// <summary>Creates a <see cref="FileUploadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FileUploadName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FileUploadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FileUploadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FileUploadName"/> with the pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileuploadId">The <c>Fileupload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FileUploadName"/> constructed from the provided ids.</returns>
        public static FileUploadName FromAccountDatasourceFileupload(string accountId, string datasourceId, string fileuploadId) =>
            new FileUploadName(ResourceNameType.AccountDatasourceFileupload, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), fileuploadId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileuploadId, nameof(fileuploadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileUploadName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileuploadId">The <c>Fileupload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileUploadName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>.
        /// </returns>
        public static string Format(string accountId, string datasourceId, string fileuploadId) =>
            FormatAccountDatasourceFileupload(accountId, datasourceId, fileuploadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FileUploadName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileuploadId">The <c>Fileupload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FileUploadName"/> with pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>.
        /// </returns>
        public static string FormatAccountDatasourceFileupload(string accountId, string datasourceId, string fileuploadId) =>
            s_accountDatasourceFileupload.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fileuploadId, nameof(fileuploadId)));

        /// <summary>Parses the given resource name string into a new <see cref="FileUploadName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fileUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FileUploadName"/> if successful.</returns>
        public static FileUploadName Parse(string fileUploadName) => Parse(fileUploadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FileUploadName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FileUploadName"/> if successful.</returns>
        public static FileUploadName Parse(string fileUploadName, bool allowUnparsed) =>
            TryParse(fileUploadName, allowUnparsed, out FileUploadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FileUploadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fileUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileUploadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileUploadName, out FileUploadName result) =>
            TryParse(fileUploadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FileUploadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fileUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FileUploadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fileUploadName, bool allowUnparsed, out FileUploadName result)
        {
            gax::GaxPreconditions.CheckNotNull(fileUploadName, nameof(fileUploadName));
            gax::TemplatedResourceName resourceName;
            if (s_accountDatasourceFileupload.TryParseName(fileUploadName, out resourceName))
            {
                result = FromAccountDatasourceFileupload(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fileUploadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FileUploadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string datasourceId = null, string fileuploadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            DatasourceId = datasourceId;
            FileuploadId = fileuploadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FileUploadName"/> class from the component parts of pattern
        /// <c>accounts/{account}/dataSources/{datasource}/fileUploads/{fileupload}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasourceId">The <c>Datasource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileuploadId">The <c>Fileupload</c> ID. Must not be <c>null</c> or empty.</param>
        public FileUploadName(string accountId, string datasourceId, string fileuploadId) : this(ResourceNameType.AccountDatasourceFileupload, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), datasourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasourceId, nameof(datasourceId)), fileuploadId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileuploadId, nameof(fileuploadId)))
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
        /// The <c>Account</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>Datasource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasourceId { get; }

        /// <summary>
        /// The <c>Fileupload</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FileuploadId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountDatasourceFileupload: return s_accountDatasourceFileupload.Expand(AccountId, DatasourceId, FileuploadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FileUploadName);

        /// <inheritdoc/>
        public bool Equals(FileUploadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FileUploadName a, FileUploadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FileUploadName a, FileUploadName b) => !(a == b);
    }

    public partial class FileUpload
    {
        /// <summary>
        /// <see cref="gsmdv::FileUploadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::FileUploadName FileUploadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::FileUploadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFileUploadRequest
    {
        /// <summary>
        /// <see cref="gsmdv::FileUploadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gsmdv::FileUploadName FileUploadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gsmdv::FileUploadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

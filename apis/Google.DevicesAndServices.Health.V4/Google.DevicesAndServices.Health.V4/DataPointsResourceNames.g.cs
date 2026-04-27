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
using gax = Google.Api.Gax;
using gdhv = Google.DevicesAndServices.Health.V4;
using sys = System;

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Resource name for the <c>DataPoint</c> resource.</summary>
    public sealed partial class DataPointName : gax::IResourceName, sys::IEquatable<DataPointName>
    {
        /// <summary>The possible contents of <see cref="DataPointName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
            /// </summary>
            UserDataTypeDataPoint = 1,
        }

        private static gax::PathTemplate s_userDataTypeDataPoint = new gax::PathTemplate("users/{user}/dataTypes/{data_type}/dataPoints/{data_point}");

        /// <summary>Creates a <see cref="DataPointName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataPointName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataPointName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataPointName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataPointName"/> with the pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPointId">The <c>DataPoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataPointName"/> constructed from the provided ids.</returns>
        public static DataPointName FromUserDataTypeDataPoint(string userId, string dataTypeId, string dataPointId) =>
            new DataPointName(ResourceNameType.UserDataTypeDataPoint, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), dataTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)), dataPointId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataPointId, nameof(dataPointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataPointName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPointId">The <c>DataPoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataPointName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
        /// </returns>
        public static string Format(string userId, string dataTypeId, string dataPointId) =>
            FormatUserDataTypeDataPoint(userId, dataTypeId, dataPointId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataPointName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPointId">The <c>DataPoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataPointName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>.
        /// </returns>
        public static string FormatUserDataTypeDataPoint(string userId, string dataTypeId, string dataPointId) =>
            s_userDataTypeDataPoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataPointId, nameof(dataPointId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataPointName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataPointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataPointName"/> if successful.</returns>
        public static DataPointName Parse(string dataPointName) => Parse(dataPointName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataPointName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataPointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataPointName"/> if successful.</returns>
        public static DataPointName Parse(string dataPointName, bool allowUnparsed) =>
            TryParse(dataPointName, allowUnparsed, out DataPointName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataPointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataPointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataPointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataPointName, out DataPointName result) => TryParse(dataPointName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataPointName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataPointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataPointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataPointName, bool allowUnparsed, out DataPointName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataPointName, nameof(dataPointName));
            gax::TemplatedResourceName resourceName;
            if (s_userDataTypeDataPoint.TryParseName(dataPointName, out resourceName))
            {
                result = FromUserDataTypeDataPoint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataPointName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataPointName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataPointId = null, string dataTypeId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataPointId = dataPointId;
            DataTypeId = dataTypeId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataPointName"/> class from the component parts of pattern
        /// <c>users/{user}/dataTypes/{data_type}/dataPoints/{data_point}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataPointId">The <c>DataPoint</c> ID. Must not be <c>null</c> or empty.</param>
        public DataPointName(string userId, string dataTypeId, string dataPointId) : this(ResourceNameType.UserDataTypeDataPoint, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), dataTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)), dataPointId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataPointId, nameof(dataPointId)))
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
        /// The <c>DataPoint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataPointId { get; }

        /// <summary>
        /// The <c>DataType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataTypeId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserDataTypeDataPoint: return s_userDataTypeDataPoint.Expand(UserId, DataTypeId, DataPointId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataPointName);

        /// <inheritdoc/>
        public bool Equals(DataPointName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataPointName a, DataPointName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataPointName a, DataPointName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataType</c> resource.</summary>
    public sealed partial class DataTypeName : gax::IResourceName, sys::IEquatable<DataTypeName>
    {
        /// <summary>The possible contents of <see cref="DataTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/dataTypes/{data_type}</c>.</summary>
            UserDataType = 1,
        }

        private static gax::PathTemplate s_userDataType = new gax::PathTemplate("users/{user}/dataTypes/{data_type}");

        /// <summary>Creates a <see cref="DataTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataTypeName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DataTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataTypeName"/> with the pattern <c>users/{user}/dataTypes/{data_type}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataTypeName"/> constructed from the provided ids.</returns>
        public static DataTypeName FromUserDataType(string userId, string dataTypeId) =>
            new DataTypeName(ResourceNameType.UserDataType, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), dataTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTypeName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTypeName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}</c>.
        /// </returns>
        public static string Format(string userId, string dataTypeId) => FormatUserDataType(userId, dataTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTypeName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTypeName"/> with pattern
        /// <c>users/{user}/dataTypes/{data_type}</c>.
        /// </returns>
        public static string FormatUserDataType(string userId, string dataTypeId) =>
            s_userDataType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataTypeName"/> if successful.</returns>
        public static DataTypeName Parse(string dataTypeName) => Parse(dataTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTypeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataTypeName"/> if successful.</returns>
        public static DataTypeName Parse(string dataTypeName, bool allowUnparsed) =>
            TryParse(dataTypeName, allowUnparsed, out DataTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTypeName, out DataTypeName result) => TryParse(dataTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/dataTypes/{data_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTypeName, bool allowUnparsed, out DataTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataTypeName, nameof(dataTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_userDataType.TryParseName(dataTypeName, out resourceName))
            {
                result = FromUserDataType(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataTypeId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataTypeId = dataTypeId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataTypeName"/> class from the component parts of pattern
        /// <c>users/{user}/dataTypes/{data_type}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTypeId">The <c>DataType</c> ID. Must not be <c>null</c> or empty.</param>
        public DataTypeName(string userId, string dataTypeId) : this(ResourceNameType.UserDataType, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), dataTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTypeId, nameof(dataTypeId)))
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
        /// The <c>DataType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataTypeId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserDataType: return s_userDataType.Expand(UserId, DataTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataTypeName);

        /// <inheritdoc/>
        public bool Equals(DataTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataTypeName a, DataTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataTypeName a, DataTypeName b) => !(a == b);
    }

    public partial class DataPoint
    {
        /// <summary>
        /// <see cref="gdhv::DataPointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::DataPointName DataPointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::DataPointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataPointRequest
    {
        /// <summary>
        /// <see cref="gdhv::DataPointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::DataPointName DataPointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::DataPointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataPointsRequest
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTypeName ParentAsDataTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataPointRequest
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTypeName ParentAsDataTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteDataPointsRequest
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTypeName ParentAsDataTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataPointName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DataPointName> DataPointNames
        {
            get => new gax::ResourceNameList<DataPointName>(Names, s => string.IsNullOrEmpty(s) ? null : DataPointName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class RollUpDataPointsRequest
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTypeName ParentAsDataTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DailyRollUpDataPointsRequest
    {
        /// <summary>
        /// <see cref="DataTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTypeName ParentAsDataTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DataType
    {
        /// <summary>
        /// <see cref="gdhv::DataTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::DataTypeName DataTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::DataTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportExerciseTcxRequest
    {
        /// <summary>
        /// <see cref="gdhv::DataPointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdhv::DataPointName DataPointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdhv::DataPointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

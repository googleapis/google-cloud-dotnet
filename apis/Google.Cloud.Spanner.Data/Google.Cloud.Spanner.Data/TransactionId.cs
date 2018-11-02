// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A TransactionId holds identifying information about an active transaction in
    /// Cloud Spanner.  Since it is serializable, it enables you to send this information
    /// to another process or machine so it may connect to the same transaction.
    /// </summary>
    public sealed class TransactionId : IEquatable<TransactionId>
    {
        internal TransactionId(string connectionString, string session, string id, TimestampBound timestampBound)
        {
            ConnectionString = connectionString;
            Session = session;
            TimestampBound = timestampBound;
            Id = id;
        }

        /// <summary>
        /// The connection string this transaction was created in.
        /// </summary>
        public string ConnectionString { get; }
        internal string Session { get; }
        internal string Id { get; }
        internal TimestampBound TimestampBound { get; }

        /// <summary>
        /// Returns a Base64 encoded string that can later be serialized back into a <see cref="TransactionId"/>
        /// using <see cref="TransactionId.FromBase64String"/>
        /// </summary>
        /// <returns>The base64 encoded string.</returns>
        public string ToBase64String()
        {
            var structValue = new Struct();
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                structValue.Fields[nameof(ConnectionString)] = new Value {StringValue = ConnectionString};
            }
            if (!string.IsNullOrEmpty(Session))
            {
                structValue.Fields[nameof(Session)] = new Value { StringValue = Session };
            }
            if (!string.IsNullOrEmpty(Id))
            {
                structValue.Fields[nameof(Id)] = new Value { StringValue = Id };
            }
            if (TimestampBound != null)
            {
                structValue.Fields[nameof(TimestampBound)] = new Value { StringValue = TimestampBound.ToBase64String() };
            }
            return structValue.ToByteString().ToBase64();
        }

        /// <summary>
        /// Creates an instance of <see cref="TransactionId"/> given its Base64 encoded string.
        /// </summary>
        /// <param name="base64String">The string provided by <see cref="TransactionId.ToBase64String"/>.</param>
        /// <returns>A new instance of <see cref="TransactionId"/>.</returns>
        public static TransactionId FromBase64String(string base64String)
        {
            var structValue = new Struct();
            structValue.MergeFrom(ByteString.FromBase64(base64String));
            string connectionString = null, session = null, id = null;
            TimestampBound timestampBound = null;

            if (structValue.Fields.TryGetValue(nameof(ConnectionString), out Value connectionStringValue))
            {
                connectionString = connectionStringValue.StringValue;
            }
            if (structValue.Fields.TryGetValue(nameof(Session), out Value sessionStringValue))
            {
                session = sessionStringValue.StringValue;
            }
            if (structValue.Fields.TryGetValue(nameof(Id), out Value idValue))
            {
                id = idValue.StringValue;
            }
            if (structValue.Fields.TryGetValue(nameof(TimestampBound), out Value timestampBoundModeValue))
            {
                timestampBound = TimestampBound.FromBase64String(timestampBoundModeValue.StringValue);
            }
            return new TransactionId(connectionString, session, id, timestampBound);
        }

        /// <inheritdoc />
        public bool Equals(TransactionId other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return string.Equals(ConnectionString, other.ConnectionString) && string.Equals(Session, other.Session)
                && string.Equals(Id, other.Id) && Equals(TimestampBound, other.TimestampBound);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            var transactionId = obj as TransactionId;
            return transactionId != null && Equals(transactionId);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = ConnectionString?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (Session?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Id?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (TimestampBound?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}

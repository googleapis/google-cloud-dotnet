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

using Google.Protobuf;

namespace Google.Cloud.Datastore.V1
{
    // Factory methods to create new instances. We have to create a new instance each time as the class is mutable.
    public partial class TransactionOptions
    {
        /// <summary>
        /// Creates options for a read-only transaction.
        /// </summary>
        /// <returns>A <see cref="TransactionOptions"/> for a read-only transaction.</returns>
        public static TransactionOptions CreateReadOnly() => new TransactionOptions { ReadOnly = new Types.ReadOnly() };

        /// <summary>
        /// Creates options for a transaction that will retry a previous one, identified by <paramref name="previousTransactionId"/>.
        /// </summary>
        /// <param name="previousTransactionId">The ID of the transaction being retried.</param>
        /// <returns>A <see cref="TransactionOptions"/> for a transaction to retry.</returns>
        public static TransactionOptions CreateForRetry(ByteString previousTransactionId) =>
            new TransactionOptions { ReadWrite = new Types.ReadWrite { PreviousTransaction = previousTransactionId } };

        /// <summary>
        /// Creates options for a read-write transaction. (This is equivalent to not specifying transaction options at all.)
        /// </summary>
        /// <returns>A <see cref="TransactionOptions"/> for a read-write transaction.</returns>
        public static TransactionOptions CreateReadWrite() => new TransactionOptions { ReadWrite = new Types.ReadWrite() };
    }
}

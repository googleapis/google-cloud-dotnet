// Copyright 2017 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Indicates the mode for the transaction.
    /// </summary>
    public enum TransactionMode
    {
        /// <summary>
        /// Read-only transactions provide guaranteed consistency across several reads,
        /// but do not allow writes. Read-only transactions can be configured to read at
        /// timestamps in the past. Read-only transactions do not need to be committed and
        /// do not take locks.
        /// </summary>
        ReadOnly = 0,

        /// <summary>
        /// Locking read-write transactions are the only transaction type that support writing
        /// data into Cloud Spanner. These transactions rely on pessimistic locking and, if
        /// necessary, two-phase commit. Locking read-write transactions may abort, requiring
        /// the application to retry.
        /// </summary>
        ReadWrite = 1
    }
}

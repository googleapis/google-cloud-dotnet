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

using System;
using Google.Protobuf;

namespace Google.Cloud.Spanner.V1
{
    //TODO: make this internal (internalsvisibleto the test dll)
    /// <summary>
    /// testonly
    /// </summary>
    public static class TestExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        public static Func<Session, SessionName> SessionGetter = session => session.SessionName;

        /// <summary>
        /// 
        /// </summary>
        public static Func<Transaction, ByteString> TransactionIdGetter = tx => tx.Id;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public static SessionName GetSessionName(this Session session)
        {
            return SessionGetter(session);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static ByteString GetTransactionId(this Transaction transaction)
        {
            return TransactionIdGetter(transaction);
        }
    }
}

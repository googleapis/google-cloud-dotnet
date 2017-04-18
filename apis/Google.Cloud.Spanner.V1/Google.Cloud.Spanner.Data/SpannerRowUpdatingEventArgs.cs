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

// ReSharper disable EmptyNamespace

using System;
using System.Data;
using System.Data.Common;

namespace Google.Cloud.Spanner
{
#if NET451
    /// <summary>
    /// </summary>
    public class SpannerRowUpdatingEventArgs : RowUpdatingEventArgs
    {
        /// <summary>
        /// </summary>
        /// <param name="row"></param>
        /// <param name="command"></param>
        /// <param name="statementType"></param>
        /// <param name="tableMapping"></param>
        public SpannerRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType,
            DataTableMapping tableMapping)
            : base(row, command, statementType, tableMapping)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public new SpannerCommand Command
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }

#endif
}
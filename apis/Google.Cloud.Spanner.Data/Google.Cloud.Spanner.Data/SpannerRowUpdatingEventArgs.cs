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


#if NET45 || NET451
using System;
using System.Data;
using System.Data.Common;
using Google.Api.Gax;

#endif

namespace Google.Cloud.Spanner.Data
{
#if NET45 || NET451

    /// <summary>
    /// Provides data for the RowUpdating event of the Spanner data provider.
    /// </summary>
    public sealed class SpannerRowUpdatingEventArgs : RowUpdatingEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpannerRowUpdatingEventArgs"/> class.
        /// </summary>
        /// <param name="row">The DataRow sent through an Update. Must not be null.</param>
        /// <param name="command">The <see cref="SpannerCommand"/> executed when Update is called.
        /// May be null.</param>
        /// <param name="statementType">The type of SQL statement executed.</param>
        /// <param name="tableMapping">The DataTableMapping sent through an Update.
        /// May be null.</param>
        public SpannerRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType,
            DataTableMapping tableMapping)
            : base(row, command, statementType, tableMapping)
        {
            GaxPreconditions.CheckNotNull(row, nameof(row));
            Command = (SpannerCommand) command;
        }

        /// <summary>
        /// Gets the <see cref="SpannerCommand"/> executed when Update is called.
        /// </summary>
        public new SpannerCommand Command { get;  }
    }

#endif
}

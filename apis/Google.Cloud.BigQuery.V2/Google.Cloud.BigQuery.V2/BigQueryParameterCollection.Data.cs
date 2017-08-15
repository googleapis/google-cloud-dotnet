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
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed partial class BigQueryParameterCollection : DbParameterCollection
    {
        /// <inheritdoc />
        public override int Add(object value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override bool Contains(string value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int IndexOf(string parameterName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void RemoveAt(string parameterName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override void SetParameter(int index, DbParameter value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override void SetParameter(string parameterName, DbParameter value)
        {
            throw new NotImplementedException();
        }

#if NET45
        /// <inheritdoc />
        public override bool IsFixedSize { get; }
        /// <inheritdoc />
        public override bool IsReadOnly { get; }
        /// <inheritdoc />
        public override bool IsSynchronized { get; }
#endif
        /// <inheritdoc />
        public override object SyncRoot { get; }

        /// <inheritdoc />
        public override void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Remove(object value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IEnumerator GetEnumerator() => ((IEnumerable<BigQueryParameter>) this).GetEnumerator();

        /// <inheritdoc />
        protected override DbParameter GetParameter(int index)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbParameter GetParameter(string parameterName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void AddRange(Array values)
        {
            throw new NotImplementedException();
        }
    }
}

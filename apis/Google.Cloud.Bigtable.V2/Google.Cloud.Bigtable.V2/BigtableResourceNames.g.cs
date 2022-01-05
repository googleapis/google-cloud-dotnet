// Copyright 2022 Google LLC
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

using gcbcv = Google.Cloud.Bigtable.Common.V2;

namespace Google.Cloud.Bigtable.V2
{
    public partial class ReadRowsRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class SampleRowKeysRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class MutateRowRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class MutateRowsRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class CheckAndMutateRowRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class ReadModifyWriteRowRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbcv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }
}

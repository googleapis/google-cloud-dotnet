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

using System.Text;
using Google.Api.Gax;

namespace Microsoft.EntityFrameworkCore.Storage.Internal
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerSqlGenerationHelper : RelationalSqlGenerationHelper
    {
        //Note: This helper, used throughout SQL generation logic, holds provider specific settings such
        // as delimiters and statement terminators.

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public SpannerSqlGenerationHelper(RelationalSqlGenerationHelperDependencies dependencies)
            : base(dependencies)
        {
        }

        // Spanner does not support multiple statements per query or in DDL. So in all cases, adding a
        // terminating semicolon just causes issues -- so we return an empty string for the statement
        // terminator.
        /// <inheritdoc />
        public override string StatementTerminator { get; } = "";

        /// <inheritdoc />
        public override void GenerateParameterName(StringBuilder builder, string name)
        {
            builder.Append(GenerateParameterName(name));
        }

        //Note we remove the shema because spanner does not support schema based names.
        /// <inheritdoc />
        public override string DelimitIdentifier(string name, string schema)
            => DelimitIdentifier(name);

        /// <inheritdoc />
        public override void DelimitIdentifier(StringBuilder builder, string name, string schema)
            => DelimitIdentifier(builder, name);

        /// <inheritdoc />
        public override string DelimitIdentifier(string identifier)
            => $"{EscapeIdentifier(GaxPreconditions.CheckNotNullOrEmpty(identifier, nameof(identifier)))}";

        /// <inheritdoc />
        public override void DelimitIdentifier(StringBuilder builder, string identifier)
        {
            GaxPreconditions.CheckNotNullOrEmpty(identifier, nameof(identifier));
            EscapeIdentifier(builder, identifier);
        }
    }
}
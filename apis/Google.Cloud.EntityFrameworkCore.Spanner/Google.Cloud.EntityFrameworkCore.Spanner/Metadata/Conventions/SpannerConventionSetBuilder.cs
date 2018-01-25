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

using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Microsoft.EntityFrameworkCore.Metadata.Conventions
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerConventionSetBuilder : RelationalConventionSetBuilder
    {
        //Note: This class can be used to create Spanner specific EFCore conventions.

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public SpannerConventionSetBuilder(
            RelationalConventionSetBuilderDependencies dependencies)
            : base(dependencies)
        {
        }

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public static ConventionSet Build()
        {
            var spannerTypeMapper = new SpannerTypeMapper(new RelationalTypeMapperDependencies());

            return new SpannerConventionSetBuilder(
                    new RelationalConventionSetBuilderDependencies(spannerTypeMapper, null, null))
                .AddConventions(
                    new CoreConventionSetBuilder(
                            new CoreConventionSetBuilderDependencies(spannerTypeMapper))
                        .CreateConventionSet());
        }
    }
}
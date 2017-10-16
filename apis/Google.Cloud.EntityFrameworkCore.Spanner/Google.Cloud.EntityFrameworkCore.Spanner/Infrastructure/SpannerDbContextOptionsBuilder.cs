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

using Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure
{
    /// <summary>
    /// Allows Spanner specific configuration to be performed on <see cref="DbContextOptions" />.
    /// </summary>
    public class SpannerDbContextOptionsBuilder
        : RelationalDbContextOptionsBuilder<SpannerDbContextOptionsBuilder, SpannerOptionsExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpannerDbContextOptionsBuilder" /> class.
        /// </summary>
        /// <param name="optionsBuilder"> The options builder. </param>
        public SpannerDbContextOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
            : base(optionsBuilder)
        {
        }
    }
}
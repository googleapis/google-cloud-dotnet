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

using Google.Api.Gax;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure.Internal
{
    /// <summary>
    /// </summary>
    public class SpannerOptionsExtension : RelationalOptionsExtension
    {
        /// <summary>
        /// </summary>
        public SpannerOptionsExtension()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="original"></param>
        protected SpannerOptionsExtension(SpannerOptionsExtension original)
            : base(original)
        {
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        protected override RelationalOptionsExtension Clone()
            => new SpannerOptionsExtension(this);

        /// <inheritdoc />
        public override bool ApplyServices(IServiceCollection services)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            services.AddEntityFrameworkSpanner();

            return true;
        }
    }
}
// Copyright 2019 Google Inc. All Rights Reserved.
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

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Interface for implementing providers that can name trace spans 
    /// </summary>
    public interface ICloudTraceNameProvider
    {
        /// <summary>
        /// When overriden in an implementing class it will return the name of the trace span based off the content
        /// in the HttpContext
        /// </summary>
        /// <param name="httpContext">The current request's HttpContext</param>
        /// <returns>A string with the name of the trace</returns>
        Task<string> GetTraceNameAsync(HttpContext httpContext);
    }
}
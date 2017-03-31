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
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Shared extensions for AspNetCore code.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// Extension for the <see cref="IServiceProvider"/> that will call and return 
        /// <see cref="IServiceProvider.GetService(System.Type)"/>.  If the result of the
        /// call is null it will throw.
        /// </summary>
        internal static T GetServiceCheckNotNull<T>(this IServiceProvider provider)
        {
            var message = $"No {typeof(T)} service found. Ensure the Google service is properly set up.";
            T service = provider.GetService<T>();
            GaxPreconditions.CheckState(service != null, message);
            return service;
        }
    }
}

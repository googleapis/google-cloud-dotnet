// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// A generic exception logger.
    /// </summary>
    public interface IExceptionLogger
    {
        /// <summary>
        ///  Asynchronously logs an exception that occurred.
        /// </summary>
        /// <param name="context">The current http context.  Cannot be null.</param>
        /// <param name="exception">The exception to log.  Cannot be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task LogAsync(HttpContext context, Exception exception);
    }
}

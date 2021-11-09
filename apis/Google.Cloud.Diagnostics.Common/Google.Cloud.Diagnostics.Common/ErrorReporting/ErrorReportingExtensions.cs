// Copyright 2021 Google LLC
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

using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for registering the Error Reporting component for Dependency Injection.
    /// </summary>
    public static class ErrorReportingExtensions
    {
        /// <summary>
        /// Registers the Error Reporting component for Dependency Injection.
        /// </summary>
        public static IServiceCollection AddGoogleErrorReporting(this IServiceCollection services, ErrorReportingServiceOptions options = null) =>
            services.AddSingleton(serviceProvider =>
                ContextExceptionLogger.Create(options, serviceProvider));
    }
}

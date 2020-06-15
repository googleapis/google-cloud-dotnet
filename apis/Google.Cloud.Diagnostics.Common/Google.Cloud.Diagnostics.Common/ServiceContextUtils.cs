// Copyright 2020 Google LLC
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

using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Helpers for working with a ServiceContext Struct.
    /// </summary>
    public static class ServiceContextUtils
    {
        /// <summary>
        /// The name of the service name field in a ServiceContext <see cref="Struct"/>.
        /// </summary>
        public const string ServiceContextServiceKey = "service";
        /// <summary>
        /// The name of the version field in a ServiceContext <see cref="Struct"/>.
        /// </summary>
        public const string ServiceContextVersionKey = "version";

        /// <summary>
        /// Creates a ServiceContext <see cref="Struct"/> from a given service name and version.
        /// </summary>
        /// <param name="serviceName">The service name.</param>
        /// <param name="version">The service version.</param>
        /// <returns>A ServiceContext <see cref="Struct"/>.</returns>
        /// <remarks>See https://cloud.google.com/error-reporting/reference/rest/v1beta1/ServiceContext </remarks>
        public static Struct CreateServiceContext(string serviceName, string version)
        {
            Struct serviceContext = null;
            if (serviceName != null)
            {
                serviceContext = new Struct();
                serviceContext.Fields[ServiceContextServiceKey] = Value.ForString(serviceName);
            }
            if (version != null)
            {
                serviceContext ??= new Struct();
                serviceContext.Fields[ServiceContextVersionKey] = Value.ForString(version);
            }
            return serviceContext;
        }
    }
}

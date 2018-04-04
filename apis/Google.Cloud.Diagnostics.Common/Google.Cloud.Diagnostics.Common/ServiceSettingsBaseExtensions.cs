// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Api.Gax.Grpc;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for <see cref="ServiceSettingsBase"/>.
    /// </summary>
    public static class ServiceSettingsBaseExtensions
    {
        /// <summary>
        /// The name of the stackdriver diagnostics version key.  Do not change this!
        /// </summary>
        private const string StackdriverDiagnosticsHeaderKey = "sdi";

        /// <summary>
        /// Add to the name and version of this library to the version header string 
        /// of the 'x-goog-api-client' header.
        /// </summary>
        /// <typeparam name="T">A <see cref="ServiceSettingsBase"/>.</typeparam>
        /// <param name="settings">The settings where the name and version of this 
        ///     library will be added.</param>
        /// <returns>The modified <paramref name="settings"/> object.</returns>
        public static T AppendStackdriverAssemblyVersion<T>(this T settings) where T : ServiceSettingsBase
        {
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            settings.VersionHeaderBuilder.AppendAssemblyVersion(
                StackdriverDiagnosticsHeaderKey, typeof(ServiceSettingsBaseExtensions));
            return settings;
        }
    }
}

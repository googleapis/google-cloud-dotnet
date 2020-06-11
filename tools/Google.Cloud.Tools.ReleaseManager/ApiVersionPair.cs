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

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class ApiVersionPair
    {
        /// <summary>
        /// The API ID, e.g. "Google.Cloud.Storage.V1"
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The old version, i.e. the version on the logical primary branch,
        /// or null if the API does not exist in the primary branch.
        /// </summary>
        public string OldVersion { get; }

        /// <summary>
        /// The new version, i.e. the version in the working directory, or null if
        /// the API does not exist in the working directory.
        /// </summary>
        public string NewVersion { get; }

        internal ApiVersionPair(string id, string oldVersion, string newVersion) =>
            (Id, OldVersion, NewVersion) = (id, oldVersion, newVersion);

        public override string ToString() => $"{Id}: {OldVersion ?? "(None)"} => {NewVersion ?? "(None)"}";
    }
}

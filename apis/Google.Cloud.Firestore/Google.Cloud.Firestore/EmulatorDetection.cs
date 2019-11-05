// Copyright 2019 Google LLC
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

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Specifies how the use of the Firestore emulator is detected via the FIRESTORE_EMULATOR_HOST environment variable,
    /// when used by <see cref="FirestoreDbBuilder"/>.
    /// </summary>
    public enum EmulatorDetection
    {
        /// <summary>
        /// Ignore environment variables entirely.
        /// </summary>
        None = 0,

        /// <summary>
        /// Always connect to the production servers, but throw an exception if
        /// the environment variable is set to suggest the emulator is expected.
        /// </summary>
        ProductionOnly = 1,

        /// <summary>
        /// Always connect to the emulator, throwing an exception if the environment
        /// variable is configured.
        /// </summary>
        EmulatorOnly = 2,

        /// <summary>
        /// Connect to the emulator if the environment variable is present,
        /// or production otherwise. This is a convenient option, but risks damage to
        /// production databases or running up unexpected bills if tests are accidentally
        /// run in production due to the environment variable being absent unexpectedly.
        /// (Using separate projects for production and testing is a best practice for
        /// preventing the first issue, but may be unrealistic for small or hobby projects.)
        /// </summary>
        ProductionOrEmulator = 3
    }
}

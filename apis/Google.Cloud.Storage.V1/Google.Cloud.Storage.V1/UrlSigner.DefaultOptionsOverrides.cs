// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

namespace Google.Cloud.Storage.V1;
public sealed partial class UrlSigner
{
    /// <summary>
    /// Overrides for default values for some of the options in <see cref="Options"/>.
    /// Useful for creating signers where signing options default to specific values, for instance
    /// for creating signers from a <see cref="StorageClient"/> where the scheme, host and port should
    /// default to that of the client.
    /// </summary>
    internal sealed class DefaultOptionsOverrides
    {
        internal DefaultOptionsOverrides(string scheme, string host, int? port)
        {
            Scheme = scheme;
            Host = host;
            Port = port;
        }

        /// <summary>
        /// A scheme to be used by the <see cref="UrlSigner"/> signing operations if
        /// <see cref="Options.ExplicitScheme"/> is null. May be null in which case
        /// <see cref="Options.DefaultScheme"/> will be used.
        /// </summary>
        internal string Scheme { get; }

        /// <summary>
        /// A host to be used by the <see cref="UrlSigner"/> signing operations if
        /// <see cref="Options.ExplicitHost"/> is null. May be null in which case
        /// <see cref="Options.DefaultStorageHost"/> will be used.
        /// </summary>
        internal string Host { get; }

        /// <summary>
        /// A port to be used by the <see cref="UrlSigner"/> signing operations if
        /// <see cref="Options.ExplicitPort"/> is null. May be null in which case
        /// no port will be used.
        /// </summary>
        internal int? Port { get; }
    }
}

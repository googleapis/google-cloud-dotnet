// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class PredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class PredictResponse
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class RawPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class StreamRawPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class DirectPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class DirectRawPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class StreamDirectPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class StreamDirectRawPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class StreamingPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class StreamingRawPredictRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class ExplainRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class CountTokensRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }

    public partial class GenerateContentRequest
    {
        /// <summary>
        /// <see cref="CachedContentName"/>-typed view over the <see cref="CachedContent"/> resource name property.
        /// </summary>
        public CachedContentName CachedContentAsCachedContentName
        {
            get => string.IsNullOrEmpty(CachedContent) ? null : CachedContentName.Parse(CachedContent, allowUnparsed: true);
            set => CachedContent = value?.ToString() ?? "";
        }
    }

    public partial class ChatCompletionsRequest
    {
        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }
}

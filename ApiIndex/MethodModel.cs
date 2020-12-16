// Copyright 2020, Google LLC
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

using Google.Api;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using static Google.Cloud.Tools.ApiIndex.V1.Method.Types;

namespace Google.Cloud.Tools.ApiIndex
{
    /// <summary>
    /// Internal representation of a method, without reference to any specific schema version.
    /// </summary>
    public class MethodModel
    {
        private MethodDescriptor _method;

        public MethodModel(MethodDescriptor method) =>
            _method = method;

        public V1.Method ToV1Method() => new V1.Method
        {
            FullName = _method.FullName,
            ShortName = _method.Name,
            Mode = _method.IsClientStreaming && _method.IsServerStreaming ? Mode.BidirectionalStreaming
               : _method.IsClientStreaming ? Mode.ClientStreaming
               : _method.IsServerStreaming ? Mode.ServerStreaming
               : Mode.Unary,
            Bindings = { GetBindings().Select(binding => binding.ToV1Binding()) }
        };

        private IEnumerable<MethodBindingModel> GetBindings()
        {
            var rule = _method.SafeGetOption(AnnotationsExtensions.Http);

            // Some APIs only support gRPC, so don't have HTTP bindings.
            if (rule is null)
            {
                yield break;
            }
            yield return MethodBindingModel.FromHttpRule(rule);
            foreach (var additionalBinding in rule.AdditionalBindings)
            {
                yield return MethodBindingModel.FromHttpRule(additionalBinding);
            }
        }

        // No need for this model to be public yet...
        private class MethodBindingModel
        {
            private static readonly HttpMethod s_patchMethod = new HttpMethod("PATCH");
            public string HttpMethod { get; }
            public string Path { get; }

            private MethodBindingModel(HttpMethod httpMethod, string path) =>
                (HttpMethod, Path) = (httpMethod.Method, path);

            internal static MethodBindingModel FromHttpRule(HttpRule rule)
            {
                (HttpMethod httpMethod, string path) = rule.PatternCase switch
                {
                    HttpRule.PatternOneofCase.Get => (System.Net.Http.HttpMethod.Get, rule.Get),
                    HttpRule.PatternOneofCase.Post => (System.Net.Http.HttpMethod.Post, rule.Post),
                    HttpRule.PatternOneofCase.Patch => (s_patchMethod, rule.Patch),
                    HttpRule.PatternOneofCase.Put => (System.Net.Http.HttpMethod.Put, rule.Put),
                    HttpRule.PatternOneofCase.Delete => (System.Net.Http.HttpMethod.Delete, rule.Delete),
                    HttpRule.PatternOneofCase.Custom => (new HttpMethod(rule.Custom.Kind), rule.Custom.Path),
                    _ => throw new ArgumentException("HTTP rule has no pattern")
                };
                return new MethodBindingModel(httpMethod, path);
            }

            internal HttpBinding ToV1Binding() => new HttpBinding
            {
                HttpMethod = HttpMethod,
                Path = Path
            };
        }
    }
}

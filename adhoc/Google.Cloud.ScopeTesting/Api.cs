// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.ScopeTesting
{
    public abstract class Api
    {
        public static Api Create<T>(Action<T> test)
        {
            return new Api<T>(test);
        }

        public abstract string TestDefaultCreate();
        public abstract string TestWithCredentials(string file);
        public abstract string TestWithCredentialsAndScopes(string file);
    }

    public class Api<T> : Api
    {
        private Action<T> _test;

        public Api(Action<T> test) => _test = test;

        public override string TestDefaultCreate()
        {
            var client = (T) typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name == "Create" && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(ServiceEndpoint))
                .Single()
                .Invoke(null, new object[] { null, null });
            return Test(client);
        }

        public override string TestWithCredentials(string file)
        {
            var credentials = GoogleCredential.FromFile(file);
            var endpoint = (ServiceEndpoint) typeof(T).GetProperty("DefaultEndpoint").GetValue(null);
            var channel = new Channel(endpoint.ToString(), credentials.ToChannelCredentials());
            var client = (T) typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name == "Create" && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(Channel))
                .Single()
                .Invoke(null, new object[] { channel, null });
            return Test(client);
        }

        public override string TestWithCredentialsAndScopes(string file)
        {
            var scopes = (IReadOnlyList<string>) typeof(T).GetProperty("DefaultScopes").GetValue(null);
            var credentials = GoogleCredential.FromFile(file).CreateScoped(scopes);
            var endpoint = (ServiceEndpoint) typeof(T).GetProperty("DefaultEndpoint").GetValue(null);
            var channel = new Channel(endpoint.ToString(), credentials.ToChannelCredentials());
            var client = (T) typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name == "Create" && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(Channel))
                .Single()
                .Invoke(null, new object[] { channel, null });
            return Test(client);
        }

        private string Test(T client)
        {
            try
            {
                _test(client);
                return "Call succeeded";
            }
            catch (RpcException e)
            {
                return $"Call failed with status {e.Status.StatusCode}";
            }
        }

        public override string ToString() => typeof(T).Namespace.Substring("Google.Cloud.".Length);
    }
}

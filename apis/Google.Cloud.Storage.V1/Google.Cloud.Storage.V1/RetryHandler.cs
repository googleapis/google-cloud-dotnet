// Copyright 2022 Google Inc. All Rights Reserved.
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

using Google.Apis.Http;
using Google.Apis.Storage.v1;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Handler for exponential backoff for request messages which permit retries.
    /// This is similar to BackoffHandler in Google.Apis.Http, but that doesn't give us enough flexibility.
    /// This handler does not enforce a maximum number of retries; that's configured via <see cref="ConfigurableMessageHandler.NumTries"/>.
    /// </summary>
    internal sealed class RetryHandler : IHttpUnsuccessfulResponseHandler
    {
        private static readonly int[] s_retriableErrorCodes =
        {
                408, // Request timeout
                429, // Too many requests
                500, // Internal server error
                502, // Bad gateway
                503, // Service unavailable
                504 // Gateway timeout
        };
        private static RetryHandler s_instance = new RetryHandler();

        private RetryHandler() { }

        internal static void MarkAsRetriable<TResponse>(StorageBaseServiceRequest<TResponse> request) =>
            request.AddUnsuccessfulResponseHandler(s_instance);

        // This function is designed to support asynchrony in case we need to examine the response content, but for now we only need the status code
        internal static Task<bool> IsRetriableResponse(HttpResponseMessage response) => 
            Task.FromResult(s_retriableErrorCodes.Contains(((int)response.StatusCode)));

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            var retry = args.SupportsRetry && await IsRetriableResponse(args.Response).ConfigureAwait(false);
            if (!retry)
            {
                return false;
            }
            // The first failure will have args.CurrentFailedTry set to 1,
            // whereas we want the first delay to be 1 second. We use Math.Min on the power
            // rather than on the result to obtain a max retry of 32 seconds without risking
            // calling Math.Pow with a huge number.
            int power = Math.Min(args.CurrentFailedTry - 1, 5);
            double seconds = Math.Pow(2.0, power);
            var delay = TimeSpan.FromSeconds(seconds);
            await Task.Delay(delay, args.CancellationToken).ConfigureAwait(false);
            return true;
        }
    }
}

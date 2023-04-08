// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Bigquery.v2;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Util;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Handler for exponential backoff for request messages which permit retries.
    /// This is similar to BackoffHandler in Google.Apis.Http, but that doesn't give us enough flexibility.
    /// This handler does not enforce a maximum number of retries; that's configured via <see cref="ConfigurableMessageHandler.NumTries"/>.
    /// </summary>
    internal sealed class RetryHandler : IHttpUnsuccessfulResponseHandler
    {
        private static readonly string[] s_retriableErrors = { "rateLimitExceeded", "backendError" };

        private static readonly RetryHandler s_instance = new RetryHandler();

        private RetryHandler() { }

        internal static void MarkAsRetriable<TResponse>(BigqueryBaseServiceRequest<TResponse> request) =>
            request.AddUnsuccessfulResponseHandler(s_instance);

        internal static async Task<bool> IsRetriableResponse(HttpResponseMessage response)
        {
            StandardResponse<object> errorResponse = null;
            try
            {
                // Always retry 502 errors.
                if (response.StatusCode == HttpStatusCode.BadGateway)
                {
                    return true;
                }
                
                // For other errors, check the response content.
                var str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                errorResponse = NewtonsoftJsonSerializer.Instance.Deserialize<StandardResponse<object>>(str);
                var errors = errorResponse.Error?.Errors;
                // If we couldn't deserialize properly, or the result doesn't contain any reasons, we won't retry.
                return errors?.All(singleError => s_retriableErrors.Contains(singleError.Reason)) ?? false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            var retry = args.SupportsRetry && 
                await IsRetriableResponse(args.Response).ConfigureAwait(false);
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

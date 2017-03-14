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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Threading.Tasks;
using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    public class EExceptionLogger : EIExceptionLogger
    {
        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly ServiceContext _serviceContext;

        private readonly IConsumer<ReportedErrorEvent> _consumer;

        internal EExceptionLogger(IConsumer<ReportedErrorEvent> consumer, string serviceName, string version)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        public void Log(Exception exception, HttpContext context = null)
        {
            throw new NotImplementedException();
        }

        public Task LogAsync(Exception exception, HttpContext context = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occured 
        /// and populates a <see cref="HttpRequestContext"/> object.
        /// </summary>
        private HttpRequestContext CreateHttpRequestContext(HttpContext context)
        {
            HttpRequest request = context?.Request;
            HttpResponse response = context?.Response;

            return new HttpRequestContext()
            {
                Method = request?.HttpMethod ?? "",
                Url = request?.Url?.ToString() ?? "",
                UserAgent = request?.UserAgent ?? "",
                ResponseStatusCode = response?.StatusCode ?? 0,
            };
        }

        /// <summary>
        /// Gets infromation about the exception that occured and populates
        /// a <see cref="ReportedErrorEvent"/> object.
        /// </summary>
        internal ReportedErrorEvent CreateReportRequest(Exception exception, HttpContext context)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = ErrorReportingUtils.CreateSourceLocation(exception)
            };

            return new ReportedErrorEvent()
            {
                Message = exception.ToString() ?? "",
                Context = errorContext,
                //ServiceContext = _serviceContext,
                EventTime = Timestamp.FromDateTime(DateTime.UtcNow),
            };
        }
    }
}

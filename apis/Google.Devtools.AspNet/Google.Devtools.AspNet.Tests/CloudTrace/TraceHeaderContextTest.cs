// Copyright 2016 Google Inc. All Rights Reserved.
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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Specialized;
using System.Web;
using Xunit;

namespace Google.Devtools.AspNet.Tests
{
    public class TraceHeaderContextTest
    {
        private static readonly string TraceId = "105445aa7843bc8bf206b12000100f00";
        private static readonly ulong SpanId = 81237123;

        /// <summary>
        /// Create the string trace header value with an optional mask.
        /// </summary>
        private string CreateTraceHeaderValue(int? mask = null)
        {
            string headerValue = TraceId + "/" + SpanId + ";";
            if (mask != null)
            {
                headerValue += "o=" + mask;
            }
            return headerValue;
        }

        /// <summary>
        /// Create a <see cref="NameValueCollection"/> with the trace header set.
        /// </summary>
        private NameValueCollection CreateCollectionWithTraceHeader(string header)
        {
            NameValueCollection headers = new NameValueCollection();
            headers.Add(TraceHeaderContext.TraceHeader, header);
            return headers;
        }

        /// <summary>
        /// Checks that a <see cref="TraceHeaderContext"/> has no span or trace id and
        /// should not trace.
        /// </summary>
        private void CheckInvalid(TraceHeaderContext context)
        {
            Assert.Null(context.GetSpanId());
            Assert.Null(context.GetTraceId());
            Assert.False(context.ShouldTrace());
        }

        [Fact]
        public void FromRequest_NoHeader()
        {
            HttpRequest request = new HttpRequest("file_name", "https://www.google.com", "");
            CheckInvalid(TraceHeaderContext.FromRequest(request));
        }

        [Fact]
        public void FromRequest_InvalidHeader()
        {
            NameValueCollection collection = CreateCollectionWithTraceHeader("1234=0");
            CheckInvalid(TraceHeaderContext.FromCollection(collection));
        }

        [Fact]
        public void FromRequest_Valid()
        {
            NameValueCollection collection = CreateCollectionWithTraceHeader(CreateTraceHeaderValue());
            TraceHeaderContext context = TraceHeaderContext.FromCollection(collection);

            Assert.True(SpanId == context.GetSpanId());
            Assert.Equal(TraceId, context.GetTraceId());
            Assert.False(context.ShouldTrace());

        }

        [Fact]
        public void FromRequest_ValidNoTrace()
        {
            NameValueCollection collection = CreateCollectionWithTraceHeader(CreateTraceHeaderValue(0));
            TraceHeaderContext context = TraceHeaderContext.FromCollection(collection);

            Assert.True(SpanId == context.GetSpanId());
            Assert.Equal(TraceId, context.GetTraceId());
            Assert.False(context.ShouldTrace());
        }

        [Fact]
        public void FromRequest_ValidTrace()
        {
            NameValueCollection collection = CreateCollectionWithTraceHeader(CreateTraceHeaderValue(1));
            TraceHeaderContext context = TraceHeaderContext.FromCollection(collection);

            Assert.True(SpanId == context.GetSpanId());
            Assert.Equal(TraceId, context.GetTraceId());
            Assert.True(context.ShouldTrace());
        }

    }
}
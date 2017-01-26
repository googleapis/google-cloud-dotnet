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
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Diagnostics.Common
{
    public static class ErrorReportingExtension
    {
        public static Struct ToStruct(this ReportedErrorEvent errorEvent)
        {
            GaxPreconditions.CheckNotNull(errorEvent, nameof(errorEvent));
            var jsonFormatter = new JsonFormatter(JsonFormatter.Settings.Default);
            return Struct.Parser.ParseJson(jsonFormatter.Format(errorEvent));

            /*
            GaxPreconditions.CheckNotNull(errorEvent, nameof(errorEvent));

            

            return new Struct
            {
                Fields = {
                    { "message", new Value { StringValue = errorEvent.Message }  },
                    { "context", new Value { StructValue = context } },
                    { "serviceContext", new Value { StructValue = serviceContext } },
                }
            };*/
        }

        public static Struct ToStruct(this ServiceContext serviceContext)
        {
            return new Struct
            {
                Fields = {
                    { "service", new Value { StringValue = serviceContext?.Service } },
                    { "version", new Value { StringValue = serviceContext?.Version } },
                },
            };
        }

        public static Struct ToStruct(this HttpRequestContext httpRequestContext)
        {
            return new Struct
            {
                Fields = {
                    { "method", new Value { StringValue = httpRequestContext?.Method } },
                    { "url", new Value { StringValue = httpRequestContext?.Url } },
                    { "userAgent", new Value { StringValue = httpRequestContext?.UserAgent } },
                    { "responseStatusCode", new Value {  NumberValue = httpRequestContext?.ResponseStatusCode ?? 0 } },
                }
            };
        }

        public static Struct ToStruct(this SourceLocation sourceLocation)
        {
            return new Struct
            {
                Fields = {
                    { "filePath", new Value { StringValue = sourceLocation?.FilePath } },
                    { "lineNumber", new Value {  NumberValue = sourceLocation?.LineNumber ?? 0} },
                    { "functionName", new Value { StringValue = sourceLocation?.FunctionName } },
                }
            };
        }
/*
        public static Struct ToStruct(this ErrorContext errorContext)
        {
            return new Struct
            {
                Fields = {
                    { "httpRequest", new Value { StructValue = httpRequest } },
                    { "reportLocation", new Value { StructValue = reportLocation } },
                }
            };
        }
        */

    }
}


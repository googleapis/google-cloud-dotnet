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

using Google.Apis.Logging;
using Google.Cloud.Scheduler.V1;
using Google.Cloud.Translation.V2;
using Google.Cloud.Vision.V1;
using System.Collections.Generic;
using static Google.Apis.Http.ConfigurableMessageHandler;

namespace Google.Cloud.Tools.Snippets
{
    public class FaqSnippets
    {
        public void RestLogging()
        {
            // Sample: RestLogging
            // Required using directives:
            // using static Google.Apis.Http.ConfigurableMessageHandler;
            // using Google.Apis.Logging;
            // using Google.Cloud.Translation.V2;

            // Register a verbose console logger
            ApplicationContext.RegisterLogger(new ConsoleLogger(LogLevel.All));

            // Create a translation client
            TranslationClient client = TranslationClient.Create();

            // Configure which events the message handler will log.
            client.Service.HttpClient.MessageHandler.LogEvents =
                LogEventType.RequestHeaders | LogEventType.ResponseBody;

            // Make the request
            client.ListLanguages();
            // End sample
        }

        public void ProtoRepeatedField1()
        {
            // Sample: ProtoRepeatedField1
            // In normal code you'd populate these individual requests with more
            // information.
            AnnotateImageRequest request1 = new AnnotateImageRequest();
            AnnotateImageRequest request2 = new AnnotateImageRequest();

            // Create the batch request using an object initializer
            BatchAnnotateImagesRequest batch = new BatchAnnotateImagesRequest
            {
                // Populate the repeated field with a collection initializer
                Requests = { request1, request2 }
            };
            // End sample
        }

        public void ProtoRepeatedField2()
        {
            // Sample: ProtoRepeatedField2
            // In normal code you'd populate these individual requests with more
            // information.
            AnnotateImageRequest request1 = new AnnotateImageRequest();
            AnnotateImageRequest request2 = new AnnotateImageRequest();

            // Populate the batch without using an object initializer, just by calling
            // Add on the repeated field
            BatchAnnotateImagesRequest batch = new BatchAnnotateImagesRequest();
            batch.Requests.Add(request1);
            batch.Requests.Add(request2);
            // End sample
        }

        public void ProtoRepeatedField3()
        {
            // Sample: ProtoRepeatedField3
            // In normal code you'd populate these individual requests with more
            // information.
            List<AnnotateImageRequest> requests = new List<AnnotateImageRequest>
            {
                new AnnotateImageRequest(),
                new AnnotateImageRequest()
            };

            // Create the batch request using an object initializer
            BatchAnnotateImagesRequest batch = new BatchAnnotateImagesRequest
            {
                // Populate the repeated field using the Add overload that accepts
                // an IEnumerable<T>
                Requests = { requests }
            };
            // End sample
        }

        public void ProtoMap1()
        {
            // Sample: ProtoMap1
            HttpTarget target = new HttpTarget
            {
                Headers =
                {
                    {  "X-Custom-Header1", "Value1" },
                    {  "X-Custom-Header2", "Value2" },
                }
            };
            // End sample
        }

        public void ProtoMap2()
        {
            // Sample: ProtoMap2
            HttpTarget target = new HttpTarget
            {
                Headers =
                {
                    ["X-Custom-Header1"] = "Value1",
                    ["X-Custom-Header2"] = "Value2",
                }
            };
            // End sample
        }

        public void ProtoMap3()
        {
            // Sample: ProtoMap3
            HttpTarget target = new HttpTarget();
            target.Headers["X-Custom-Header1"] = "Value1";
            target.Headers["X-Custom-Header2"] = "Value2";
            // End sample
        }
    }
}

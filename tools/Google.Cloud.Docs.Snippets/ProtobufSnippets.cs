// Copyright 2022 Google LLC
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

using Google.Cloud.Scheduler.V1;
using Google.Cloud.Vision.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Docs.Snippets;

public class ProtobufSnippets
{
    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
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

    [Fact]
    public void ProtoMap3()
    {
        // Sample: ProtoMap3
        HttpTarget target = new HttpTarget();
        target.Headers["X-Custom-Header1"] = "Value1";
        target.Headers["X-Custom-Header2"] = "Value2";
        // End sample
    }

    [Fact]
    public void StructConversions()
    {
        // Sample: StructConversions
        Vertex message = new Vertex { X = 1, Y = 2 };

        // Convert from a message type to Struct
        Struct structValue = Struct.Parser.ParseJson(message.ToString());

        // Convert from a Struct to a given message type
        message = Vertex.Parser.ParseJson(structValue.ToString());
        // End sample

        Assert.Equal(message, new Vertex { X = 1, Y = 2 });
    }

    [Fact]
    public void JsonFormatting()
    {
        // Sample: JsonFormatting
        // Simplest way of formatting a message as JSON: call ToString().
        Vertex message = new Vertex { X = 1, Y = 0 };
        // Result: { "x": 1 }
        string defaultJson = message.ToString();

        // Formatting a message as JSON using custom settings.
        JsonFormatter.Settings formatterSettings = JsonFormatter.Settings.Default.WithFormatDefaultValues(true);
        JsonFormatter formatter = new JsonFormatter(formatterSettings);
        // Result: { "x": 1, "y": 0 }
        string customJson = formatter.Format(message);
        // End sample

        Assert.Equal("{ \"x\": 1 }", defaultJson);
        Assert.Equal("{ \"x\": 1, \"y\": 0 }", customJson);
    }

    [Fact]
    public void JsonParsing()
    {
        // Sample: JsonParsing
        // Simplest way of parsing JSON with default settings.
        string json1 = "{ \"x\": 1, \"y\": 2 }";
        Vertex vertex1 = Vertex.Parser.ParseJson(json1);

        // Parsing JSON using custom settings.
        JsonParser.Settings parserSettings = JsonParser.Settings.Default.WithIgnoreUnknownFields(true);
        JsonParser parser = new JsonParser(parserSettings);
        string json2 = "{ \"x\": 1, \"y\": 2, \"z\": 3 }";
        Vertex vertex2 = parser.Parse<Vertex>(json2);
        // End sample

        Assert.Equal(vertex1, vertex2);
    }
}

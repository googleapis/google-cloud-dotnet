// Copyright 2021 Google LLC
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

using Google.Cloud.AIPlatform.V1.Schema.Predict.Instance;
using Google.Protobuf.WellKnownTypes;
using Xunit;
using static Google.Protobuf.WellKnownTypes.Value;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    public class ValueConverterTest
    {
        [Fact]
        public void ToMessage_Value()
        {
            var structValue = new Struct
            {
                Fields =
                {
                    { "content", ForString("some-content") },
                    { "mimeType", ForString("some-mime-type") },
                }
            };
            var value = ForStruct(structValue);
            var actualMessage = ValueConverter.ToMessage<TextSentimentPredictionInstance>(value);
            var expectedMessage = new TextSentimentPredictionInstance { Content = "some-content", MimeType = "some-mime-type" };
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void ToMessage_Struct()
        {
            var structValue = new Struct
            {
                Fields =
                {
                    { "content", ForString("some-content") },
                    { "mimeType", ForString("some-mime-type") },
                }
            };
            var actualMessage = ValueConverter.ToMessage<TextSentimentPredictionInstance>(structValue);
            var expectedMessage = new TextSentimentPredictionInstance { Content = "some-content", MimeType = "some-mime-type" };
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void ToStruct()
        {
            var message = new TextSentimentPredictionInstance { Content = "some-content", MimeType = "some-mime-type" };
            var structValue = ValueConverter.ToStruct(message);
            Assert.Equal(2, structValue.Fields.Count);
            Assert.Equal("some-content", structValue.Fields["content"].StringValue);
            Assert.Equal("some-mime-type", structValue.Fields["mimeType"].StringValue);
        }

        [Fact]
        public void ToValue()
        {
            var message = new TextSentimentPredictionInstance { Content = "some-content", MimeType = "some-mime-type" };
            var value = ValueConverter.ToValue(message);
            Assert.Equal(KindOneofCase.StructValue, value.KindCase);
            var structValue = value.StructValue;
            Assert.Equal(2, structValue.Fields.Count);
            Assert.Equal("some-content", structValue.Fields["content"].StringValue);
            Assert.Equal("some-mime-type", structValue.Fields["mimeType"].StringValue);
        }
    }
}

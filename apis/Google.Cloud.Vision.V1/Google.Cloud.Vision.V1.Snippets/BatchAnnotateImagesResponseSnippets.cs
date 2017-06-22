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
// limitations under the License.

using System;
using Xunit;

namespace Google.Cloud.Vision.V1.Snippets
{
    public class BatchAnnotateImagesResponseSnippets
    {
        [Fact]
        public void ThrowOnAnyError()
        {
            // Snippet: ThrowOnAnyError
            // We create a request which passes simple validation, but isn't a valid image.
            Image image = Image.FromBytes(new byte[10]);
            // Just a single request in this example, but usually BatchAnnotateImages would be
            // used with multiple requests.
            var request = new AnnotateImageRequest
            {
                Image = image,
                Features = { new Feature { Type = Feature.Types.Type.SafeSearchDetection } }
            };
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            try
            {
                BatchAnnotateImagesResponse response = client.BatchAnnotateImages(new[] { request });
                // ThrowOnAnyError will throw if any individual response in response.Responses
                // contains an error. Other responses may still have useful results.
                // Errors can be detected manually by checking the Error property in each
                // individual response.
                response.ThrowOnAnyError();
            }
            catch (AggregateException e)
            {
                // Because a batch can have multiple errors, the exception thrown is AggregateException.
                // Each inner exception is an AnnotateImageException
                foreach (AnnotateImageException innerException in e.InnerExceptions)
                {
                    Console.WriteLine(innerException.Response.Error);
                }
            }
            // End snippet
        }
    }
}

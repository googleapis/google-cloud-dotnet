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

using System.IO;

namespace Google.Cloud.Vision.V1.Snippets
{
    public class ImageSnippets
    {
        // Not an actual test... just examples
        public void FactoryMethods()
        {
            // Sample: FactoryMethods
            Image image1 = Image.FromFile("Pictures/LocalImage.jpg");
            Image image2 = Image.FromUri("https://cloud.google.com/images/devtools-icon-64x64.png");
            Image image3 = Image.FromStorageUri("gs://my-bucket/my-file");

            byte[] bytes = ReadImageData(); // For example, from a database
            Image image4 = Image.FromBytes(bytes);

            using (Stream stream = OpenImageStream()) // Any regular .NET stream
            {
                Image image5 = Image.FromStream(stream);
            }
            // End sample
        }

        private static byte[] ReadImageData() => null;
        private static Stream OpenImageStream() => null;
    }
}

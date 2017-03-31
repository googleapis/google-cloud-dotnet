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

namespace Google.Cloud.Speech.V1.Snippets
{
    public class RecognitionAudioSnippets
    {
        // Not an actual test... just examples
        public void FactoryMethods()
        {
            // Sample: FactoryMethods
            RecognitionAudio audio1 = RecognitionAudio.FromFile("Sound/SpeechSample.flac");
            RecognitionAudio audio2 = RecognitionAudio.FetchFromUri("https://.../HostedSpeech.flac");
            RecognitionAudio audio3 = RecognitionAudio.FromStorageUri("gs://my-bucket/my-file");

            byte[] bytes = ReadAudioData(); // For example, from a database
            RecognitionAudio audio4 = RecognitionAudio.FromBytes(bytes);

            using (Stream stream = OpenAudioStream()) // Any regular .NET stream
            {
                RecognitionAudio audio5 = RecognitionAudio.FromStream(stream);
            }
            // End sample
        }

        private static byte[] ReadAudioData() => null;
        private static Stream OpenAudioStream() => null;
    }
}

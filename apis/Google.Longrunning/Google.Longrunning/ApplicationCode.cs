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

// SAMPLE CODE ONLY: THIS IS FOR DISCUSSION, NOT RELEASE!

using Google.DeepThought.V1;
using System;
using System.Threading.Tasks;

namespace JonSkeet.ReallyGreatApp
{
    public class ApplicationCode
    {
        // In "batch" code, async is a bit annoying - we should have synchronous ways of
        // achieving what we need, but we don't care if it takes a long time to complete.
        public class PollingBatch
        {
            public void Execute()
            {
                var client = DeepThoughtClient.Create();
                var operation = client.ContemplateLife("What is the meaning of life, the universe and everything?");
                var response = operation.Poll();
                var answer = response.Answer;
                Console.WriteLine($"Loonquawl - the answer is ${answer}");
            }
        }

        // Sometimes batch code doesn't need the answer just yet... but it needs to store the operation
        // name so it can retrieve it later.
        public class StoredBatch
        {
            private static void SaveOperationName(string name) { }
            private static string LoadOperationName() => "some stored value";

            public void InitialRun()
            {
                var client = DeepThoughtClient.Create();
                var operation = client.ContemplateLife("...");
                SaveOperationName(operation.Name);
            }

            public void CheckResults()
            {
                var client = DeepThoughtClient.Create();
                var name = LoadOperationName();
                var operation = client.ResumeContemplateLife(name);
                if (operation.Done)
                {
                    var response = operation.Result;
                    var answer = response.Answer;
                }
                else
                {
                    // Maybe poll, maybe store it away.
                }
            }
        }

        // Web apps often use async code in .NET these days. Imagine one where
        // we have two web API methods, one to start contemplating the meaning of life,
        // and one (polled from the client) to check the results.
        public class WebApi
        {
            public static async Task<object> ContemplateLife(string question)
            {
                var client = DeepThoughtClient.Create();
                var operation = await client.ContemplateLifeAsync("...");
                if (operation.Done)
                {
                    return new { Result = operation.Result };
                }
                else
                {
                    return new { Name = operation.Name };
                }
            }

            public static async Task<object> CheckContemplationResult(string name)
            {
                var client = DeepThoughtClient.Create();
                var operation = await client.ResumeContemplateLifeAsync(name);
                if (operation.Done)
                {
                    return new { Result = operation.Result };
                }
                else
                {
                    // Nope, still not finished...
                    return new { Name = operation.Name };
                }
            }
        }

        public class WinFormsApp
        {
            private async void buttonClicked(object sender, EventArgs e)
            {
                var client = await DeepThoughtClient.CreateAsync();
                var operation = await client.ContemplateLifeAsync("...");
                var response = await operation.PollAsync();
                Console.WriteLine($"Imagine actually writing to a WinForms TextBox: {response.Answer}");
            }
        }
    }
}

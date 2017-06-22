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

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.StressTests
{
    internal class SpannerStressTests : BaseStressTest
    {
        private static int s_myCounter = 1;
        private static readonly string s_guid = Guid.NewGuid().ToString();
        private static readonly Random s_rnd = new Random(Environment.TickCount);

        protected  override async Task<TimeSpan> TestWrite1(Stopwatch sw)
        {
            using (var connection = new SpannerConnection(Program.SpannerConnectionString))
            {

                var localCounter = Interlocked.Increment(ref s_myCounter);
                var insertCommand = connection.CreateInsertCommand(
                    "bookTable", new SpannerParameterCollection
                    {
                        {"ID", SpannerDbType.String},
                        {"Title", SpannerDbType.String}
                    });
                insertCommand.Parameters["ID"].Value = $"{s_guid}{localCounter}";
                insertCommand.Parameters["Title"].Value = "Title";

                bool retry = true;
                long delay = 0;
                while (retry)
                {
                    retry = false;
                    try
                    {
                        //The open is implicit here...
                        await insertCommand.ExecuteNonQueryAsync();
                    }
                    catch (Exception e) when (e.IsTransientSpannerFault())
                    {
                        //TODO(benwu): replace with topaz.
                        retry = true;
                        Console.WriteLine("retrying due to " + e.Message);
                        delay = delay * 2;
                        delay += s_rnd.Next(100);
                        delay = Math.Min(delay, 5000);
                        await Task.Delay(TimeSpan.FromMilliseconds(delay));
                    }
                }
            }
            return sw.Elapsed;
        }
    }
}
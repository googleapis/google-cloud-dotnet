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

using Google.Apis.Download;
using Google.Apis.Upload;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1.ThroughputTool
{
    internal sealed class ProgressReporter : IDisposable, IProgress<IDownloadProgress>, IProgress<IUploadProgress>
    {
        private static readonly TimeSpan s_reportPeriod = TimeSpan.FromSeconds(5);

        private readonly Stopwatch _stopwatch;
        private readonly TaskCompletionSource<int> _tcs;
        private readonly Thread _reportingThread;
        private long _bytesProcessed;

        internal ProgressReporter()
        {
            _stopwatch = Stopwatch.StartNew();
            _tcs = new TaskCompletionSource<int>();
            _reportingThread = new Thread(ReportPeriodically);
            _reportingThread.Start();
        }

        private void ReportPeriodically()
        {
            Console.WriteLine("Timestamp  Elapsed         MB     Mbps");
            while (!_tcs.Task.IsCompleted)
            {
                _tcs.Task.Wait(s_reportPeriod);
                DateTime now = DateTime.UtcNow;
                TimeSpan elapsed = _stopwatch.Elapsed;
                double totalSeconds = elapsed.TotalSeconds;
                long bytesProcessed = Interlocked.Read(ref _bytesProcessed);
                double megabytesProcessed = bytesProcessed / (1024.0 * 1024.0);
                double megabitsProcessed = megabytesProcessed * 8;
                double? mbps = totalSeconds < 0.1 ? default(double?) : megabitsProcessed / totalSeconds;
                Console.WriteLine($"{now:HH:mm:ss}   {elapsed:hh':'mm':'ss}  {megabytesProcessed,8:####0.00}   {mbps,6:##0.00}");
            }
        }

        public void Dispose()
        {
            _tcs.TrySetResult(0);
            _reportingThread.Join();
        }

        public void Report(IUploadProgress value) =>
            Interlocked.Exchange(ref _bytesProcessed, value.BytesSent);

        public void Report(IDownloadProgress value) =>
            Interlocked.Exchange(ref _bytesProcessed, value.BytesDownloaded);
    }
}

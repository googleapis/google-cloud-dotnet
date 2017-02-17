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

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.Log4Net
{
    internal sealed class MemoryLogQueue : ILogQueue
    {
        private struct LogEntryExtraSize
        {
            public LogEntryExtraSize(LogEntryExtra logEntryExtra, int size)
            {
                LogEntryExtra = logEntryExtra;
                Size = size;
            }

            public LogEntryExtra LogEntryExtra { get; }
            public int Size { get; }
        }

        public MemoryLogQueue(long maxMemorySize, int maxMemoryCount)
        {
            _maxMemorySize = maxMemorySize;
            _maxMemoryCount = maxMemoryCount;
        }

        private readonly object _lock = new object();
        private readonly long _maxMemorySize;
        private readonly int _maxMemoryCount;

        private readonly Queue<LogEntryExtraSize> _q = new Queue<LogEntryExtraSize>();
        private long _currentMemorySize = 0;
        private DateTimeRange _lost;

        public void Enqueue(IEnumerable<LogEntryExtra> logEntries)
        {
            lock (_lock)
            {
                foreach (var entry in logEntries)
                {
                    if ((_maxMemoryCount > 0 && _q.Count >= _maxMemoryCount) || (_maxMemorySize > 0 && _currentMemorySize > _maxMemorySize))
                    {
                        var lostEntry = _q.Dequeue();
                        _currentMemorySize -= lostEntry.Size;
                        var lost = new DateTimeRange(lostEntry.LogEntryExtra.Entry.Timestamp.ToDateTime(), lostEntry.LogEntryExtra.Entry.Timestamp.ToDateTime());
                        _lost = lost.Union(_lost);
                    }
                    var sizedEntry = new LogEntryExtraSize(entry, _maxMemorySize > 0 ? entry.Entry.CalculateSize() : 0);
                    _q.Enqueue(sizedEntry);
                    _currentMemorySize += sizedEntry.Size;
                }
            }
        }

        public Task<long?> GetPreviousExecutionIdAsync() => Task.FromResult<long?>(null);

        public Task<LogQueuePeekResult> PeekAsync(int maximumCount, CancellationToken cancellationToken)
        {
            lock (_lock)
            {
                var entries = _q.Take(_lost == null ? maximumCount : maximumCount - 1).Select(x => x.LogEntryExtra).ToList();
                var lost = _lost;
                // TODO: Not quite correct; the 'lost' log entry will be lost if this upload doesn't succeed.
                _lost = null;
                return Task.FromResult(new LogQueuePeekResult(entries, lost));
            }
        }

        public Task RemoveUntilAsync(long id, CancellationToken cancellationToken)
        {
            lock (_lock)
            {
                while (_q.Count > 0 && _q.Peek().LogEntryExtra.Id <= id)
                {
                    var dequeued = _q.Dequeue();
                    _currentMemorySize -= dequeued.Size;
                }
                return Task.FromResult(0);
            }
        }
    }
}

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
using System.Threading.Tasks;

namespace Google.Logging.Log4Net
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

        private readonly object _lockObj = new object();
        private readonly long _maxMemorySize;
        private readonly int _maxMemoryCount;

        private readonly Queue<LogEntryExtraSize> _q = new Queue<LogEntryExtraSize>();
        private long _currentMemorySize = 0;
        private long _maxIdSeen = -1;

        public DateTimeRange EnqueueAsync(IEnumerable<LogEntryExtra> logEntries)
        {
            lock (_lockObj)
            {
                DateTimeRange lostRange = null;
                foreach (var entry in logEntries)
                {
                    if ((_maxMemoryCount > 0 && _q.Count >= _maxMemoryCount) || (_maxMemorySize > 0 && _currentMemorySize > _maxMemorySize))
                    {
                        var lostEntry = _q.Dequeue();
                        _currentMemorySize -= lostEntry.Size;
                        if (lostRange == null)
                        {
                            lostRange = new DateTimeRange(lostEntry.LogEntryExtra.Entry.Timestamp(), lostEntry.LogEntryExtra.Entry.Timestamp());
                        }
                        else
                        {
                            lostRange = lostRange.WithTo(lostEntry.LogEntryExtra.Entry.Timestamp());
                        }
                    }
                    var sizedEntry = new LogEntryExtraSize(entry, _maxMemorySize > 0 ? entry.Entry.CalculateSize() : 0);
                    _q.Enqueue(sizedEntry);
                    if (entry.Id > _maxIdSeen)
                    {
                        _maxIdSeen = entry.Id;
                    }
                    _currentMemorySize += sizedEntry.Size;
                }
                return lostRange;
            }
        }

        public Task<long> GetNextIdAsync()
        {
            lock (_lockObj)
            {
                return Task.FromResult(_maxIdSeen + 1);
            }
        }

        public bool IsEmpty()
        {
            lock (_lockObj)
            {
                return _q.Count == 0;
            }
        }

        public Task<IEnumerable<LogEntryExtra>> PeekAsync(int maximumCount)
        {
            lock (_lockObj)
            {
                return Task.FromResult<IEnumerable<LogEntryExtra>>(
                    _q.Take(maximumCount).Select(x => x.LogEntryExtra).ToList());
            }
        }

        public Task RemoveUntilAsync(long id)
        {
            lock (_lockObj)
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

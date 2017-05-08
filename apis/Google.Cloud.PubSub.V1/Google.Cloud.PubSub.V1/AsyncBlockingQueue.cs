using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    internal class AsyncBlockingQueue<T>
    {
        public AsyncBlockingQueue(TaskHelper taskHelper)
        {
            _taskHelper = taskHelper;
        }

        private readonly object _lock = new object();
        private readonly TaskHelper _taskHelper;
        private readonly Queue<T> _q = new Queue<T>();

        private TaskCompletionSource<int> _qTcs;

        public void Enqueue(T item)
        {
            lock (_lock)
            {
                _q.Enqueue(item);
                if (_qTcs != null)
                {
                    _qTcs.SetResult(0);
                    _qTcs = null;
                }
            }
        }

        public async Task WaitAsync(CancellationToken ct)
        {
            TaskCompletionSource<int> cancellation = null;
            CancellationTokenRegistration registration = default(CancellationTokenRegistration);
            if (ct.CanBeCanceled)
            {
                cancellation = new TaskCompletionSource<int>();
                registration = ct.Register(() => cancellation.SetCanceled());
            }
            try
            {
                while (true)
                {
                    Task waitTask = null;
                    lock (_lock)
                    {
                        if (_q.Count > 0)
                        {
                            return;
                        }
                        if (_qTcs != null)
                        {
                            _qTcs = new TaskCompletionSource<int>();
                        }
                        waitTask = _qTcs.Task;
                    }
                    await _taskHelper.ConfigureAwait(Task.WhenAny(waitTask, cancellation.Task));
                    ct.ThrowIfCancellationRequested();
                }
            }
            finally
            {
                if (cancellation != null)
                {
                    // Unregister if previously registered for cancellation
                    registration.Dispose();
                }
            }
        }

        public IList<T> Dequeue(int max)
        {
            lock (_lock)
            {
                List<T> result = new List<T>();
                while (_q.Count > 0 && result.Count < max)
                {
                    result.Add(_q.Dequeue());
                }
                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tasks
{
    internal struct TaskAwaitable
    {
        private class Awaiter : ITaskAwaiter
        {
            public Awaiter(Task task, TaskScheduler taskScheduler)
            {
                _task = task;
                _taskScheduler = taskScheduler;
            }

            private Task _task;
            private TaskScheduler _taskScheduler;

            public void OnCompleted(Action continuation) => _task.ContinueWith(_ => continuation(), _taskScheduler);
            public void UnsafeOnCompleted(Action continuation) => _task.ContinueWith(_ => continuation(), _taskScheduler);
            public bool IsCompleted => _task.IsCompleted;
            public void GetResult() { }
        }

        private class ForwardingAwaiter : ITaskAwaiter
        {
            public ForwardingAwaiter(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter)
            {
                _awaiter = awaiter;
            }

            private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _awaiter;

            public void OnCompleted(Action continuation) => _awaiter.OnCompleted(continuation);
            public void UnsafeOnCompleted(Action continuation) => _awaiter.UnsafeOnCompleted(continuation);
            public bool IsCompleted => _awaiter.IsCompleted;
            public void GetResult() => _awaiter.GetResult();
        }

        public TaskAwaitable(Task task, TaskScheduler taskScheduler)
        {
            _awaiter = taskScheduler == null ?
                (ITaskAwaiter)new ForwardingAwaiter(task.ConfigureAwait(false).GetAwaiter()) :
                (ITaskAwaiter)new Awaiter(task, taskScheduler);
        }

        private ITaskAwaiter _awaiter;

        public ITaskAwaiter GetAwaiter() => _awaiter;
    }

    internal struct TaskAwaitable<T>
    {
        private class Awaiter : ITaskAwaiter<T>
        {
            public Awaiter(Task<T> task, TaskScheduler taskScheduler)
            {
                _task = task;
                _taskScheduler = taskScheduler;
            }

            private Task<T> _task;
            private TaskScheduler _taskScheduler;

            public void OnCompleted(Action continuation) => _task.ContinueWith(_ => continuation(), _taskScheduler);
            public void UnsafeOnCompleted(Action continuation) => _task.ContinueWith(_ => continuation(), _taskScheduler);
            public bool IsCompleted => _task.IsCompleted;
            public T GetResult() => _task.Result;
        }

        private class ForwardingAwaiter : ITaskAwaiter<T>
        {
            public ForwardingAwaiter(ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter)
            {
                _awaiter = awaiter;
            }

            private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _awaiter;

            public void OnCompleted(Action continuation) => _awaiter.OnCompleted(continuation);
            public void UnsafeOnCompleted(Action continuation) => _awaiter.UnsafeOnCompleted(continuation);
            public bool IsCompleted => _awaiter.IsCompleted;
            public T GetResult() => _awaiter.GetResult();
        }

        public TaskAwaitable(Task<T> task, TaskScheduler taskScheduler)
        {
            _awaiter = taskScheduler == null ?
                (ITaskAwaiter<T>)new ForwardingAwaiter(task.ConfigureAwait(false).GetAwaiter()) :
                (ITaskAwaiter<T>)new Awaiter(task, taskScheduler);
        }

        private ITaskAwaiter<T> _awaiter;

        public ITaskAwaiter<T> GetAwaiter() => _awaiter;
    }
}

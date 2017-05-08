using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tests.Testing
{
    internal class TestAwaiter : ITaskAwaiter
    {
        public TestAwaiter(Task task, TaskScheduler taskScheduler)
        {
            _task = task;
            _taskScheduler = taskScheduler;
        }

        private Task _task;
        private TaskScheduler _taskScheduler;

        public void OnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public void UnsafeOnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public bool IsCompleted => _task.IsCompleted;
        public void GetResult() { }
    }

    internal class TestAwaiter<T> : ITaskAwaiter<T>
    {
        public TestAwaiter(Task<T> task, TaskScheduler taskScheduler)
        {
            _task = task;
            _taskScheduler = taskScheduler;
        }

        private Task<T> _task;
        private TaskScheduler _taskScheduler;

        public void OnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public void UnsafeOnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
         public bool IsCompleted => _task.IsCompleted;
        public T GetResult() => _task.Result;
    }
}

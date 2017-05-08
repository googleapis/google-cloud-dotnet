using System;
using System.Runtime.CompilerServices;

namespace Google.Cloud.PubSub.V1.Tasks
{
    internal class ForwardingAwaiter : ITaskAwaiter
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

    internal class ForwardingAwaiter<T> : ITaskAwaiter<T>
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
}

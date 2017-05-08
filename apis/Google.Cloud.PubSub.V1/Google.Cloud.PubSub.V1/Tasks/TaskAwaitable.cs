using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tasks
{
    internal struct TaskAwaitable
    {
        public TaskAwaitable(ITaskAwaiter awaiter)
        {
            _awaiter = awaiter;
        }

        private ITaskAwaiter _awaiter;

        public ITaskAwaiter GetAwaiter() => _awaiter;
    }

    internal struct TaskAwaitable<T>
    {
        public TaskAwaitable(ITaskAwaiter<T> awaiter)
        {
            _awaiter = awaiter;
        }

        private ITaskAwaiter<T> _awaiter;

        public ITaskAwaiter<T> GetAwaiter() => _awaiter;
    }
}

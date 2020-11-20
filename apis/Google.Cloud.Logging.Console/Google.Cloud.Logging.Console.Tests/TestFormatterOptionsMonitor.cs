using Microsoft.Extensions.Options;
using System;

namespace Google.Cloud.Logging.Console.Tests
{
    internal class TestFormatterOptionsMonitor<TOptions> : IOptionsMonitor<TOptions> where TOptions : GoogleCloudConsoleFormatterOptions
    {
        private TOptions _options;
        private event Action<TOptions, string> _onChange;
        public TestFormatterOptionsMonitor(TOptions options)
        {
            _options = options;
        }

        public TOptions Get(string name) => _options;

        public IDisposable OnChange(Action<TOptions, string> listener)
        {
            _onChange += listener;
            return null;
        }

        public TOptions CurrentValue => _options;

        public void Set(TOptions options)
        {
            _options = options;
            _onChange?.Invoke(options, "");
        }
    }
}

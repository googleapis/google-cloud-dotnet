#if NETSTANDARD2_0
using System;
using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.Diagnostics.AspNetCore.Logging
{
	/// <summary>
	/// Extensions to add <see cref="GoogleLoggerProvider"/>s to an <see cref="ILoggingBuilder"/>.
	/// </summary>
	/// 
	/// <example>
	/// <code>
	/// .ConfigureLogging((hostingContext, logging) =>
	/// {
	///     string projectId = "[Google Cloud Platform project ID]";
	///     var serviceProvider = logging.Services.BuildServiceProvider();
	///     logging.AddGoogle(serviceProvider);
	///     ...
	/// }
	/// </code>
	/// </example>
	/// 
	/// <remarks>
	/// Logs to Google Stackdriver Cloud Logging.
	/// Docs: https://cloud.google.com/logging/docs/
	/// </remarks>
	/// <seealso cref="GoogleLogger"/>
	public static class GoogleLogBuilderExtensions
    {
		/// <summary>
		/// Adds a <see cref="GoogleLoggerProvider"/> for <see cref="GoogleLogger"/>s.
		/// </summary>
		/// <param name="builder">The logger builder. Cannot be null.</param>
		/// <param name="serviceProvider">The service provider to resolve additional services from.</param>
		/// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
		///     The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project ID will be
		///     detected from the platform.</param>
		/// <param name="options">Optional, options for the logger.</param>
		/// <param name="client">Optional, logging client.</param>
		public static void AddGoogle(this ILoggingBuilder builder, 
								IServiceProvider serviceProvider, 
								string projectId = null,
								LoggerOptions options = null, 
								LoggingServiceV2Client client = null)
		{
			GaxPreconditions.CheckNotNull(builder, nameof(builder));

			options = options ?? LoggerOptions.Create();
			projectId = Project.GetAndCheckProjectId(projectId, options.MonitoredResource);
			LogTarget logTarget = LogTarget.ForProject(projectId);

			var provider = GoogleLoggerProvider.Create(serviceProvider, projectId, options, client);

			builder.Services.AddSingleton<ILoggerProvider>(provider);
		}
	}
}
#endif

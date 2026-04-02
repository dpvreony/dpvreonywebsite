using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DPVreony.WebsiteBuilder.Services
{
    public class StartupBackgroundService : BackgroundService
    {
        private readonly StartupHealthCheck _healthCheck;
        private readonly ILogger<StartupBackgroundService> _logger;

        public StartupBackgroundService(
            StartupHealthCheck healthCheck,
            ILogger<StartupBackgroundService> logger)
        {
            _healthCheck = healthCheck ?? throw new ArgumentNullException(nameof(healthCheck));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Startup background service is starting. Application marked as not ready.");
            
            _healthCheck.IsReady = false;

            try
            {
                await Task.Delay(TimeSpan.FromSeconds(60), stoppingToken);
                
                _healthCheck.IsReady = true;
                _logger.LogInformation("Startup background service completed. Application marked as ready.");
            }
            catch (OperationCanceledException)
            {
                _logger.LogInformation("Startup background service was cancelled before completing.");
            }
        }
    }
}

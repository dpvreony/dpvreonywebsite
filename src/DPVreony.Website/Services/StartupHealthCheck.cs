using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DPVreony.WebsiteBuilder.Services
{
    public class StartupHealthCheck : IHealthCheck
    {
        private volatile bool _isReady;

        public bool IsReady
        {
            get => _isReady;
            set => _isReady = value;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            if (_isReady)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("The startup task has completed."));
            }

            return Task.FromResult(
                HealthCheckResult.Unhealthy("The startup task is still running."));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace PolicyEngine
{
    public class AuthorizationService : Authorization.AuthorizationBase
    {
        private readonly ILogger<AuthorizationService> _logger;
        public AuthorizationService(ILogger<AuthorizationService> logger)
        {
            _logger = logger;
        }

        public override Task<AccessResponse> CheckAccess(AccessRequest request, ServerCallContext context)
        {
            return Task.FromResult(new AccessResponse
            {
                IsGranted = false,
                Message = "You've got Buckley's mate!"
            }) ;
        }
    }
}

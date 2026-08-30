using System.Net.Mime;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Soenneker.Controllers.Base;
using Soenneker.Enums.DeployEnvironment;

namespace Soenneker.Controllers.Health;

/// <summary>
/// Provides a health check endpoint to verify if the service is online. Returns a message indicating the API status
/// based on the environment.
/// </summary>
[ApiExplorerSettings(IgnoreApi = true)]
[ApiController]
[ApiVersion("1")]
[Route("health")]
public sealed class HealthController : BaseController
{
    public HealthController(IConfiguration config) : base(config)
    {
    }

    /// <summary>
    /// Checks the health status of the API and returns a response indicating whether it is online.
    /// </summary>
    /// <returns>A 200 response with a short message in local or development environments; otherwise, an empty 200 response.</returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [Produces(MediaTypeNames.Application.Json)]
    [AllowAnonymous]
    public IActionResult Health()
    {
        string? environment = Config["Environment"];

        if (environment != DeployEnvironment.Local && environment != DeployEnvironment.Development)
            return Ok();

        const string health = "API is online";
        return Ok(health);
    }
}

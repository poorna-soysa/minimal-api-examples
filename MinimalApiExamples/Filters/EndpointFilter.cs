namespace MinimalApiExamples.Filters;

public sealed class EndpointFilter : IEndpointFilter
{
    private readonly ILogger _logger;

    public EndpointFilter(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<EndpointFilter>();
    }

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context,
        EndpointFilterDelegate next)
    {
        _logger.LogInformation($"{nameof(EndpointFilter)} Before Invoked");
        var result = await next(context);
        _logger.LogInformation($"{nameof(EndpointFilter)} After Invoked");

        return result;
    }
}

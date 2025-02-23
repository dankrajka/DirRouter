using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace DirRouter.Web.Routes.Test;

public class Endpoints(IConfiguration config)
{
    public async Task<IResult> Get()
    {
        await Task.CompletedTask;
        return Results.Ok("Test - Get");
    }
    
    public async Task<IResult> Post([FromBody] object request)
    {
        await Task.CompletedTask;
        var ser = JsonSerializer.Serialize(request);
        return Results.Ok($"Test - Post: {ser}");
    }
}
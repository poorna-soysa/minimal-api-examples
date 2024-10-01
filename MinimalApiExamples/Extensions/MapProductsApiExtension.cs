namespace MinimalApiExamples.Extensions;

public static class MapProductsApiExtension
{
    public static RouteGroupBuilder MapProductsApi(this RouteGroupBuilder group)
    {
        group.MapGet("", () => Results.Ok("Get all products"));
        group.MapGet("{id}", (int id) => Results.Ok($"Get product with ID: {id}"));
        group.MapPost("", () => Results.Ok("Create a new product"));
        group.MapPut("{id}", (int id) => Results.Ok("Update product"));
        group.MapDelete("{id}", (int id) => Results.Ok("Delete product"));

        return group;
    }
}

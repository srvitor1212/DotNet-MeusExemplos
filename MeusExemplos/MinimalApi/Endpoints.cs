using Microsoft.EntityFrameworkCore;

namespace MinimalApi;

public static class Endpoints
{
    public static void AddEndpoints(this IEndpointRouteBuilder app)
    {



        app.MapGet("/todoitems", async (ContextDb db) =>
            await db.Todos.ToListAsync());




        app.MapGet("/todoitems/complete", async (ContextDb db) =>
            await db.Todos.Where(t => t.IsComplete).ToListAsync());




        app.MapGet("/todoitems/{id}", async (int id, ContextDb db) =>
            await db.Todos.FindAsync(id)
                is Todo todo
                    ? Results.Ok(todo)
                    : Results.NotFound());




        app.MapPost("/todoitems", async (Todo todo, ContextDb db) =>
        {
            db.Todos.Add(todo);
            await db.SaveChangesAsync();

            return Results.Created($"/todoitems/{todo.Id}", todo);
        });




        app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, ContextDb db) =>
        {
            var todo = await db.Todos.FindAsync(id);

            if (todo is null) return Results.NotFound();

            todo.Name = inputTodo.Name;
            todo.IsComplete = inputTodo.IsComplete;

            await db.SaveChangesAsync();

            return Results.NoContent();
        });




        app.MapDelete("/todoitems/{id}", async (int id, ContextDb db) =>
        {
            if (await db.Todos.FindAsync(id) is Todo todo)
            {
                db.Todos.Remove(todo);
                await db.SaveChangesAsync();
                return Results.NoContent();
            }

            return Results.NotFound();
        });



    }
}

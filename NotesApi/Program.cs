using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// In-memory notes list (like a fake database)
var notes = new List<Note>();
var nextId = 1;

// GET all notes
app.MapGet("/notes", () => notes);

// GET note by id
app.MapGet("/notes/{id}", (int id) =>
{
    var note = notes.FirstOrDefault(n => n.Id == id);
    return note is not null ? Results.Ok(note) : Results.NotFound();
});

// POST create a note
app.MapPost("/notes", ([FromBody] Note note) =>
{
    note.Id = nextId++;
    notes.Add(note);
    return Results.Created($"/notes/{note.Id}", note);
});

// PUT update a note
app.MapPut("/notes/{id}", (int id, [FromBody] Note updatedNote) =>
{
    var note = notes.FirstOrDefault(n => n.Id == id);
    if (note is null) return Results.NotFound();
    note.Title = updatedNote.Title;
    note.Content = updatedNote.Content;
    return Results.NoContent();
});

// DELETE a note
app.MapDelete("/notes/{id}", (int id) =>
{
    var note = notes.FirstOrDefault(n => n.Id == id);
    if (note is null) return Results.NotFound();
    notes.Remove(note);
    return Results.NoContent();
});

app.Run();

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}

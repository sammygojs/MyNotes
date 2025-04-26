using Xunit;
using NotesApi;

public class NotesTests
{
    [Fact]
    public void Note_HasTitleAndContent()
    {
        var note = new Note { Title = "Test", Content = "Some content" };
        Assert.Equal("Test", note.Title);
        Assert.Equal("Some content", note.Content);
    }
}

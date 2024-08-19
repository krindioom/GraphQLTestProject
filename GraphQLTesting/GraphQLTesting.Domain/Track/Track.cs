using System.Collections.Immutable;

namespace GraphQLTesting.Domain.Track;

public class Track
{
    public int Id { get; private set; }

    private string _title;

    public string Title
    {
        get => _title;

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Title must be at least 3 characters long.");
            }

            _title = value;
        }
    }

    public string? Text { get; private set; }

    public IReadOnlyCollection<Actor.Actor> Actors
    {
        get => _actors.ToImmutableList();
        private set => _actors = value.ToList();
    }

    private List<Actor.Actor> _actors;

    public Track(int id, string title, string? text)
    {
        Id = id;
        Title = title;
        Text = text;
        _actors = new List<Actor.Actor>();
    }

    public void ChangeTitle(string newTitle)
    {
        Title = newTitle;
    }
}

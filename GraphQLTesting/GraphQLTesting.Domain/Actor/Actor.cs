using GraphQLTesting.Domain.Actor.Enums;
using System.Collections.Immutable;

namespace GraphQLTesting.Domain.Actor;

public class Actor
{
    public int Id { get; private set; }

    public string Name { get; private set; } = null!;

    public IReadOnlyCollection<Instrument> Instruments 
    { 
        get => _instruments.ToImmutableList(); 
        private set => _instruments = value.ToList(); 
    }

    private List<Instrument> _instruments = new List<Instrument>();

    public Actor(int id, string name)
    {
        Id = id;
        Name = name;
        _instruments = new List<Instrument>();
    }

    public void AddInstrument(Instrument instrument)
    {
        if (_instruments.Any(x => x == instrument))
        {
            return;
        }

        _instruments.Add(instrument);
    }
}

namespace SharedKernel;

public abstract class Entity
{
    private List<IDomainEvent> _domainEvents = new();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
    //clear domain events
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
    //remove domain event
    public void RemoveDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

}

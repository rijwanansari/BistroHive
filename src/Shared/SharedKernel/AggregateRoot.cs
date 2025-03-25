namespace SharedKernel;

public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot
{
    protected AggregateRoot() { }

    protected AggregateRoot(TId id) : base(id) { }
}

public interface IAggregateRoot { }

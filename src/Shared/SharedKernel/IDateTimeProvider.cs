namespace SharedKernel;

public interface IDateTimeProvider
{
    DateTime Now { get; }
    DateTime UtcNow { get; }

}

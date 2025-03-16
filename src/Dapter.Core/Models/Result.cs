namespace Dapter.Core.Models;
public record Result<T>
{
    public required T? Value { get; set; }
}


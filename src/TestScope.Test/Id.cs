namespace TestScope.Test
{
    public sealed class Id : IEquatable<Id>
    {
        public static Id New => new();

        public Guid Value { get; } = Guid.NewGuid();

        public override bool Equals(object? obj)
        {
            if (obj is not Id other) return false;

            return Value == other.Value;
        }

        public bool Equals(Id? other)
        {
            if (other == null) return false;

            return Value == other.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
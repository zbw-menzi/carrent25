namespace CarRent.Domain.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
            : this(Guid.CreateVersion7())
        {
        }

        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        public static bool operator ==(Entity left, Entity right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        public bool Equals(Entity? other)
        {
            if (other is null)
            {
                return false;
            }

            return Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Entity entity)
            {
                return Equals(entity);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

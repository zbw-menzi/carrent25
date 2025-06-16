namespace CarRent.Domain.Primitives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public abstract class ValueObject : IEquatable<ValueObject>, IComparable<ValueObject>
    {
        private readonly int? _cachedHashCode = default!;

        protected abstract IEnumerable<object?> EqualityComponents { get; }

        public static bool operator ==(ValueObject? left, ValueObject? right)
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

        public static bool operator !=(ValueObject? left, ValueObject? right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var valueObject = (ValueObject)obj;
            return EqualityComponents.SequenceEqual(valueObject.EqualityComponents);
        }

        public bool Equals(ValueObject? other)
        {
            return CompareTo(other) == 0;
        }

        public override int GetHashCode()
        {
            if (!_cachedHashCode.HasValue)
            {
                HashCode hashCode = default;

                foreach (var obj in EqualityComponents)
                {
                    hashCode.Add(obj);
                }

                var calculatedHashCode = hashCode.ToHashCode();
                SetCachedHashCode(calculatedHashCode);
            }

            return _cachedHashCode!.Value;
        }

        public int CompareTo(object? obj)
        {
            return CompareTo(obj as ValueObject);
        }

        public int CompareTo(ValueObject? other)
        {
            if (other is null)
            {
                return 1;
            }

            var thisType = GetType();
            var otherType = other.GetType();

            if (thisType != otherType)
            {
                return string.CompareOrdinal($"{thisType}", $"{otherType}");
            }

            var leftComponents = EqualityComponents.ToArray();
            var rightComponents = other.EqualityComponents.ToArray();

            for (var i = 0; i < leftComponents.Length; i++)
            {
                var comparison = CompareComponents(leftComponents[i], rightComponents[i]);
                if (comparison != 0)
                {
                    return comparison;
                }
            }

            return 0;
        }

        internal static int CompareComponents(object? left, object? right)
        {
            if (left is null && right is null)
            {
                return 0;
            }

            if (left is null)
            {
                return -1;
            }

            if (right is null)
            {
                return 1;
            }

            var leftType = left.GetType();
            var rightType = right.GetType();

            if (leftType != rightType)
            {
                return string.CompareOrdinal($"{leftType}", $"{rightType}");
            }

            return left.Equals(right) ? 0 : -1;
        }

        private void SetCachedHashCode(int hashCode)
        {
            GetCachedHashCode(this) = hashCode;
        }

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = nameof(_cachedHashCode))]
        private static extern ref int? GetCachedHashCode(ValueObject @this);
    }
}

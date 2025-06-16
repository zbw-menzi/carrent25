namespace Buhler.IdentityService.Tests.Domain.Common.Primitives
{
    using AwesomeAssertions;

    using CarRent.Domain.Primitives;

    public class ValueObjectTests
    {
        [Fact]
        public void Equals_WithNullObject_ReturnsFalse()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.Equals(null);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Equals_WithSameObject_ReturnsTrue()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.Equals(valueObject);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Equals_WithDifferentObject_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject2("value2", 2);

            // Act
            var result = valueObject1.Equals(valueObject2);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Equals_WithSameValues_ReturnsTrue()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var result = valueObject1.Equals(valueObject2);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Equals_WithDifferentValues_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = valueObject1.Equals(valueObject2);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void OpEquals_WithSameValues_ReturnsTrue()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var result = valueObject1 == valueObject2;

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void OpEquals_WithDifferentValues_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = valueObject1 == valueObject2;

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void OpNotEquals_WithSameValues_ReturnsTrue()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var result = valueObject1 != valueObject2;

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void OpNotEquals_WithDifferentValues_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = valueObject1 != null;

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void GetHashCode_WithSameValues_ReturnsSameHashCodes()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var hashCode1 = valueObject1.GetHashCode();
            var hashCode2 = valueObject2.GetHashCode();

            // Assert
            hashCode1.Should().Be(hashCode2);
        }

        [Fact]
        public void GetHashCode_WithDifferentValues_ReturnsDifferentHashCodes()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var hashCode1 = valueObject1.GetHashCode();
            var hashCode2 = valueObject2.GetHashCode();

            // Assert
            hashCode1.Should().NotBe(hashCode2);
        }

        [Fact]
        public void CompareTo_WithNullObject_ReturnsOne()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.CompareTo(null);

            // Assert
            result.Should().Be(1);
        }

        [Fact]
        public void CompareTo_WithSameObject_ReturnsZero()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.CompareTo(valueObject);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void CompareTo_WithDifferentObject_ReturnsOne()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = valueObject1.CompareTo(valueObject2);

            // Assert
            result.Should().Be(-1);
        }

        [Fact]
        public void CompareComponents_WithSameValues_ReturnsZero()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var result = ValueObject.CompareComponents(valueObject1, valueObject2);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void CompareComponents_WithDifferentValues_ReturnsOne()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = ValueObject.CompareComponents(valueObject1, valueObject2);

            // Assert
            result.Should().Be(-1);
        }

        [Fact]
        public void CompareComponents_WithNullObjectRight_ReturnsOne()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = ValueObject.CompareComponents(valueObject, null);

            // Assert
            result.Should().Be(1);
        }

        [Fact]
        public void CompareComponents_WithNullObjectLeft_ReturnsOne()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = ValueObject.CompareComponents(null, valueObject);

            // Assert
            result.Should().Be(-1);
        }

        [Fact]
        public void CompareComponents_WithNullObjects_ReturnsZero()
        {
            // Arrange + Act
            var result = ValueObject.CompareComponents(null, null);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void CompareComponents_WithSameComparables_ReturnsZero()
        {
            // Arrange + Act
            var result = ValueObject.CompareComponents("test", "test");

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void CompareComponents_WithDifferentComparableRight_ReturnsOne()
        {
            // Arrange + Act
            var result = ValueObject.CompareComponents("test1", new TestValue3());

            // Assert
            result.Should().BeGreaterThanOrEqualTo(1);
        }

        [Fact]
        public void CompareComponents_WithDifferentComparableLeft_ReturnsOne()
        {
            // Arrange + Act
            var result = ValueObject.CompareComponents(new TestValue3(), "test2");

            // Assert
            result.Should().BeLessThanOrEqualTo(-1);
        }

        [Fact]
        public void CompareComponents_WithDifferentComparableBoth_ReturnsOne()
        {
            // Arrange + Act
            var result = ValueObject.CompareComponents(new TestValue3(), new TestValue3());

            // Assert
            result.Should().Be(-1);
        }

        [Fact]
        public void CompareComponents_WithSameComparableBoth_ReturnsZero()
        {
            // Arrange
            var value = new TestValue3();

            // Act
            var result = ValueObject.CompareComponents(value, value);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void ObjectEquals_WithNullObject_ReturnsFalse()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.Equals((object)null);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void ObjectEquals_WithSameObject_ReturnsTrue()
        {
            // Arrange
            var valueObject = new TestValueObject("value1", 1);

            // Act
            var result = valueObject.Equals((object)valueObject);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void ObjectEquals_WithDifferentObject_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject2("value2", 2);

            // Act
            var result = valueObject1.Equals((object)valueObject2);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void ObjectEquals_WithSameValues_ReturnsTrue()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value1", 1);

            // Act
            var result = valueObject1.Equals((object)valueObject2);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void ObjectEquals_WithDifferentValues_ReturnsFalse()
        {
            // Arrange
            var valueObject1 = new TestValueObject("value1", 1);
            var valueObject2 = new TestValueObject("value2", 2);

            // Act
            var result = valueObject1.Equals((object)valueObject2);

            // Assert
            result.Should().BeFalse();
        }

        private sealed class TestValueObject : ValueObject
        {
            public TestValueObject(string value1, int value2)
            {
                Value1 = value1;
                Value2 = value2;
            }

            public string Value1 { get; }

            public int Value2 { get; }

            protected override IEnumerable<object?> EqualityComponents
            {
                get
                {
                    yield return Value1;
                    yield return Value2;
                }
            }
        }

        private sealed class TestValueObject2 : ValueObject
        {
            public TestValueObject2(string value1, int value2)
            {
                Value1 = value1;
                Value2 = value2;
            }

            public string Value1 { get; }

            public int Value2 { get; }

            protected override IEnumerable<object?> EqualityComponents
            {
                get
                {
                    yield return Value1;
                    yield return Value2;
                }
            }
        }

        private sealed class TestValue3;
    }
}

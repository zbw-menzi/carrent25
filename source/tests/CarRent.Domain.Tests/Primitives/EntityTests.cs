namespace Buhler.IdentityService.Tests.Domain.Common.Primitives
{
    using AwesomeAssertions;

    using CarRent.Domain.Primitives;

    using Moq;

    public class EntityTests
    {
        private sealed class TestEntity : Entity
        {
            public TestEntity()
            {
            }

            public TestEntity(Guid id)
                : base(id)
            {
            }
        }

        private sealed class TestEntity2 : Entity;

        [Fact]
        public void Constructor_WithId_AssignsIdCorrectly()
        {
            // Arrange
            var expectedId = Guid.NewGuid();

            // Act
            var entity = new TestEntity(expectedId);

            // Act + Assert
            entity.Id.Should().Be(expectedId);
        }

        [Fact]
        public void Equals_WithSameReference_ReturnsTrue()
        {
            // Arrange
            var entity = new TestEntity();

            // Act + Assert
            entity.Equals(entity).Should().BeTrue();
        }

        [Fact]
        public void Equals_WithDifferentReference_ReturnsTrue()
        {
            // Arrange
            var id = Guid.NewGuid();
            var entity1 = new TestEntity(id);
            var entity2 = new TestEntity(id);

            // Act + Assert
            entity1.Equals((object)entity2).Should().BeTrue();
        }

        [Fact]
        public void Equals_WithDifferentReferenceDifferentID_ReturnsFalse()
        {
            // Arrange
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var entity1 = new TestEntity(id1);
            var entity2 = new TestEntity(id2);

            // Act + Assert
            entity1.Equals((object)entity2).Should().BeFalse();
        }

        [Fact]
        public void Equals_WithDifferentType_ReturnsFalse()
        {
            // Arrange
            var entity1 = new TestEntity();
            var entity2 = new TestEntity2();

            // Act + Assert
            entity1.Equals(entity2).Should().BeFalse();
        }

        [Fact]
        public void OperatorEquals_WithBothNull_ReturnsTrue()
        {
            // Arrange
            TestEntity entity1 = null;
            TestEntity entity2 = null;

            // Act + Assert
            (entity1 == entity2).Should().BeTrue();
        }

        [Fact]
        public void OperatorEquals_WithLeftNull_ReturnsFalse()
        {
            // Arrange
            var entity1 = new TestEntity();
            TestEntity entity2 = null!;

            (entity1 == entity2).Should().BeFalse();
        }

        [Fact]
        public void OperatorEquals_WithRightNull_ReturnsFalse()
        {
            // Arrange
            TestEntity entity1 = null!;
            var entity2 = new TestEntity();

            (entity1 == entity2).Should().BeFalse();
        }

        [Fact]
        public void GetHashCode_ShouldBeConsistent()
        {
            // Arrange
            var entity = new TestEntity(Guid.NewGuid());

            var expectedHashCode = entity.GetHashCode();

            // Act + Assert
            entity.GetHashCode().Should().Be(expectedHashCode);
        }

        [Fact]
        public void Equals_WhenRightIsNull_ThenReturnFalse()
        {
            // Arrange
            var entity1 = new TestEntity();

            // Act + Assert
            entity1.Equals(null).Should().BeFalse();
        }

        [Fact]
        public void Equals_WhenRightIsProxy_ThenReturnFalse()
        {
            // Arrange
            var entity1 = new TestEntity();
            var entity2 = new Mock<Entity>().Object;

            // Act + Assert
            entity1.Equals(entity2).Should().BeFalse();
        }

        [Fact]
        public void Equals_WhenRightIsCastedToObjectAndSame_ThenReturnTrue()
        {
            // Arrange
            var entity1 = new TestEntity();

            // Act + Assert
            entity1.Equals((object)entity1).Should().BeTrue();
        }

        [Fact]
        public void OperatorNotEquals_WithDifferentEntities_ReturnsTrue()
        {
            // Arrange
            var entity1 = new TestEntity(Guid.NewGuid());
            var entity2 = new TestEntity(Guid.NewGuid());

            // Act + Assert
            (entity1 != entity2).Should().BeTrue();
        }

        [Fact]
        public void OperatorNotEquals_WithSameEntities_ReturnsFalse()
        {
            // Arrange
            var id = Guid.NewGuid();
            var entity1 = new TestEntity(id);
            var entity2 = new TestEntity(id);

            // Act + Assert
            (entity1 != entity2).Should().BeFalse();
        }
    }
}

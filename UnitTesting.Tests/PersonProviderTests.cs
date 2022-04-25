using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Interfaces;
using Xunit;
using Xunit.Extensions.Ordering;

namespace UnitTesting.Tests
{
    [Order(2)]
    public class PersonProviderTests
    {
        private readonly Mock<IPersonRepository> personRepositoryMock;
        private readonly PersonProvider personProvider;

        public PersonProviderTests()
        {
            personRepositoryMock = new Mock<IPersonRepository>();
            personProvider = new PersonProvider(personRepositoryMock.Object);
        }

        [Fact]
        public void GetPerson_ValidData_Success()
        {
            // Arrange
            personRepositoryMock
                .Setup(x => x.GetPerson(It.IsAny<int>()))
                .Returns(new Entities.Person
                {
                    Id = 1,
                    FirstName = "Jacek",
                    LastName = "Nowicki",
                    Email = "jnowicki@ezn.edu.pl"
                });

            // Act
            var result = personProvider.GetPerson(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Jacek", result.FirstName);
            Assert.Equal("Nowicki", result.LastName);
            Assert.Equal("jnowicki@ezn.edu.pl", result.Email);
        }

        [Fact]
        public void GetPerson_InvalidData_ExceptionThrown()
        {
            // Arrange
            personRepositoryMock
                .Setup(x => x.GetPerson(It.IsAny<int>()))
                .Returns(new Entities.Person
                {
                    Id = 2,
                    FirstName = "",
                    LastName = "",
                    Email = "aaa@bbb.com"
                });

            // Act & Assert
            Assert.Throws<Exception>(() => personProvider.GetPerson(2));
        }
    }
}

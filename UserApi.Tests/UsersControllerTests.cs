using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using UserApi.Controllers;
using UserApi.Models;
using UserApi.Services.Interface; // Asegúrate de que el espacio de nombres sea correcto
using System.Collections.Generic;

namespace UserApi.Tests
{
    public class UsersControllerTests
    {
        private readonly UsersController _controller;
        private readonly Mock<IUserRepository> _mockUserRepository;

        public UsersControllerTests()
        {
            // Configurar el mock
            _mockUserRepository = new Mock<IUserRepository>();
            
            // Crear la instancia del controlador con el mock
            _controller = new UsersController(_mockUserRepository.Object);
        }

        [Fact]
        public void GetUsers_ReturnsOkResult()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
            };
            _mockUserRepository.Setup(repo => repo.GetAllUsers()).Returns(users);

            // Act
            var result = _controller.GetUsers() as ActionResult<List<User>>;

            // Assert
            Assert.NotNull(result);
            var okResult = result.Result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
            var returnValue = okResult.Value as List<User>;
            Assert.NotNull(returnValue);
            Assert.Equal(users.Count, returnValue.Count);
        }
    }
}

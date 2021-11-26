using System;
using Xunit;
using DAL.Repositories.Impl;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System.Linq;
using Moq;

namespace DAL.Tests
{
    class TestRegionRepository
        : BaseRepository<Lab>
    {
        public TestRegionRepository(DbContext context)
            : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {

        [Fact]
        public void Create_InputRegionInstance_CalledAddMethodOfDBSetWithRegionInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<EnterpriceContext>()
                .Options;
            var mockContext = new Mock<EnterpriceContext>(opt);
            var mockDbSet = new Mock<DbSet<Lab>>();
            mockContext
                .Setup(context =>
                    context.Set<Lab>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            var repository = new TestRegionRepository(mockContext.Object);

            Lab expectedRegion = new Mock<Lab>().Object;

            //Act
            repository.Create(expectedRegion);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedRegion
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<EnterpriceContext>()
                .Options;
            var mockContext = new Mock<EnterpriceContext>(opt);
            var mockDbSet = new Mock<DbSet<Lab>>();
            mockContext
                .Setup(context =>
                    context.Set<Lab>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            //IStreetRepository repository = uow.Streets;
            var repository = new TestRegionRepository(mockContext.Object);

            Lab expectedRegion = new Lab() { LabId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRegion.LabId)).Returns(expectedRegion);

            //Act
            repository.Delete(expectedRegion.LabId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRegion.LabId
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedRegion
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<EnterpriceContext>()
                .Options;
            var mockContext = new Mock<EnterpriceContext>(opt);
            var mockDbSet = new Mock<DbSet<Lab>>();
            mockContext
                .Setup(context =>
                    context.Set<Lab>(
                        ))
                .Returns(mockDbSet.Object);

            Lab expectedRegion = new Lab() { LabId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRegion.LabId))
                    .Returns(expectedRegion);
            var repository = new TestRegionRepository(mockContext.Object);

            //Act
            var actualStreet = repository.Get(expectedRegion.LabId);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRegion.LabId
                    ), Times.Once());
            Assert.Equal(expectedRegion, actualStreet);
        }


    }
}
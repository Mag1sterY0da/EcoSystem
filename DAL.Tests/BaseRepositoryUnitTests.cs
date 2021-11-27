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
    class TestLabsRepository
        : BaseRepository<Lab>
    {
        public TestLabsRepository(DbContext context)
            : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {

        [Fact]
        public void Create_InputlabInstance_CalledAddMethodOfDBSetWithLabInstance()
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
            var repository = new TestLabsRepository(mockContext.Object);

            Lab expectedLab = new Mock<Lab>().Object;

            //Act
            repository.Create(expectedLab);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedLab
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
            var repository = new TestLabsRepository(mockContext.Object);

            Lab expectedRegion = new Lab() { LabID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRegion.LabID)).Returns(expectedRegion);

            //Act
            repository.Delete(expectedRegion.LabID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRegion.LabID
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

            Lab expectedRegion = new Lab() { LabID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRegion.LabID))
                    .Returns(expectedRegion);
            var repository = new TestLabsRepository(mockContext.Object);

            //Act
            var actualStreet = repository.Get(expectedRegion.LabID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRegion.LabID
                    ), Times.Once());
            Assert.Equal(expectedRegion, actualStreet);
        }


    }
}
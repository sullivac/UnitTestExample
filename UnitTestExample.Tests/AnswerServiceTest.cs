using System;
using Moq;
using Xunit;

namespace UnitTestExample.Test
{
    public class AnswerServiceTest
    {
        [Fact]
        public void Save_ReportsId()
        {
            // Assemble
            Mock<IAnswerRepository> stubRepository = new Mock<IAnswerRepository>();
            Mock<IAnswerReporter> mockReporter = new Mock<IAnswerReporter>();

            var sut = new AnswerService(stubRepository.Object, mockReporter.Object);

            stubRepository
                .Setup(mock => mock.Persist(6, It.IsAny<string>()))
                .Returns(1);

            // Act
            sut.Save(6);

            // Assert
            mockReporter.Verify(reporter => reporter.Report(1));
        }
    }
}

using Xunit;
using Neverlands.Infrastructure.Services;
using Neverlands.Automation.Services;
using Neverlands.Core.Interfaces;
using Moq;

namespace Neverlands.Tests;

public class AppInitTests
{
    [Fact]
    public async Task InitializeAsync_ShouldLoadAllResources()
    {
        // Arrange
        var mockNetwork = new Mock<INetworkService>();
        var mockProfile = new Mock<IProfileManager>();
        var navService = new NavigationService(mockNetwork.Object);
        var appInit = new AppInitializer(navService, mockProfile.Object);

        // Act
        var exception = await Record.ExceptionAsync(() => appInit.InitializeAsync());

        // Assert
        Assert.Null(exception);
    }
}

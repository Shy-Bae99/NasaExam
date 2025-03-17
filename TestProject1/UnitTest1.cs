using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Moq;
using NasaExam.Pages;
using NasaExam.Services;

namespace TestProject1;

public class TestProject1 : TestContext
{
    private readonly Mock<INasaService> nasaServiceMock;
    private readonly Mock<IJSRuntime> jsRuntimeMock;

    public TestProject1()
    {
        nasaServiceMock = new Mock<INasaService>();
        jsRuntimeMock = new Mock<IJSRuntime>();

        // Enregistrer les mocks dans les services
        Services.AddSingleton(nasaServiceMock.Object);
        Services.AddSingleton(jsRuntimeMock.Object);
    }

    [Fact]
    public void ApodComponent_ShouldDisplayImage_WhenImageIsFetched()
    {
        // Arrange
        var testImage = new NasaImageResponse
        {
            Url = "https://example.com/test-image.jpg",
            Title = "Test Image",
            Explanation = "This is a test image."
        };

        nasaServiceMock.Setup(s => s.GetImageOfTheDay(It.IsAny<string>()))
            .ReturnsAsync(testImage);

        // Act
        var component = RenderComponent<Apod>();

        // Assert
        var imgElement = component.Find("img");
        Assert.NotNull(imgElement);
        Assert.Contains("https://example.com/test-image.jpg", imgElement.OuterHtml);
    }

    [Fact]
    public void ApodComponent_ShouldToggleFavoriteColor_WhenFavoriteButtonClicked()
    {
        // Arrange
        var testImage = new NasaImageResponse
        {
            Url = "https://example.com/test-image.jpg",
            Title = "Test Image",
            Explanation = "This is a test image."
        };

        nasaServiceMock.Setup(s => s.GetImageOfTheDay(It.IsAny<string>()))
            .ReturnsAsync(testImage);

        jsRuntimeMock.Setup(j => j.InvokeAsync<bool>("isFavorite", It.IsAny<object[]>()))
            .ReturnsAsync(false);

        var component = RenderComponent<Apod>();

        // Act
        var button = component.Find(".ButtonFav");
        button.Click();

        // Assert
        var starElement = component.Find("span");
        Assert.Contains("pink", starElement.OuterHtml);
    }
}
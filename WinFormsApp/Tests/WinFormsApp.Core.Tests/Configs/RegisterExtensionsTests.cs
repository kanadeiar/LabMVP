using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Core.Configs;

namespace WinFormsApp.Core.Tests.Configs;

public class RegisterExtensionsTests
{
    [Fact]
    public void CoreRegister_RegisterServices_ShouldOk()
    {
        var services = new ServiceCollection();

        var provider = services.CoreRegister();

        Assert.Equal(1, provider.Count);
        Assert.Equal("ICounter", provider[0].ServiceType.Name);
    }
}
using Microsoft.JSInterop;

namespace GreenPage.Client.Services;

public class ColorSchemeService : IColorSchemeService
{
    public IJSRuntime JS { get; set; }

    public ColorSchemeService(IJSRuntime jS)
    {
        JS = jS;
    }

    public ValueTask<string> GetPreferredColorScheme()
    {
        return JS?.InvokeAsync<string>("getPreferredTheme") ?? throw new Exception("JSRuntime is not initialized");
    }

    public ValueTask SetScheme(string scheme)
    {
        return JS?.InvokeVoidAsync("setTheme", scheme) ?? throw new Exception("JSRuntime is not initialized");
    }
}

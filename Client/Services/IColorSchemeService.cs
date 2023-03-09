namespace GreenPage.Client.Services
{
    public interface IColorSchemeService
    {
        ValueTask SetScheme(string scheme);
        ValueTask<string> GetPreferredColorScheme(); 
    }
}

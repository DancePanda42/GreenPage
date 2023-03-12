namespace GreenPage.Shared.Models;

/// <summary>
///     Represent a basic model for a page.
/// </summary>
public class PageBase : ComponentBase
{
    /// <summary>
    ///     The route to the Page.
    /// </summary>
    public string Route { get; set; } = "/";

    /// <summary>
    ///     The page title.
    /// </summary>
    public string? Title { get; set; }

    /// <inheritdoc />
    public override RenderType RenderType => RenderType.Page;
}

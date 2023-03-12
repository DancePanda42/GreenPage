namespace GreenPage.Shared.Models;

public abstract class ComponentBase
{
    /// <summary>
    ///     The type to be rendered.
    /// </summary>
    public abstract RenderType RenderType { get; }

    /// <summary>
    ///     The child items.
    /// </summary>
    public IEnumerable<ComponentBase>? Children { get; }
}

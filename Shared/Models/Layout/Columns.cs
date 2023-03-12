namespace GreenPage.Shared.Models.Layout;

public class Columns : ComponentBase
{
    public override RenderType RenderType => RenderType.Columns;

    public List<ColumnDefinition> ColumnDefinitions { get; set; } = new();
}

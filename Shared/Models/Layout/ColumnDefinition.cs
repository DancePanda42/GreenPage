namespace GreenPage.Shared.Models.Layout;

/// <summary>
///     Represent a flex column
/// </summary>
public class ColumnDefinition
{
    /// <summary>
    ///     The order number.
    ///     If the value is null the column will be displayed in the assigned order.
    /// </summary>
    public int? Order { get; set; }

    /// <summary>
    ///     The Horizontal or Vertical alignment.
    ///     Default is <see cref="FlexPosition.Start"/>.
    /// </summary>
    public FlexPosition Position { get; set; } = FlexPosition.Start;

    /// <summary>
    ///     Sets the grow factor of a column.
    /// </summary>
    public float Grow { get; set; } = 1;

    /// <summary>
    ///     Sets the shrink factor of a column.
    /// </summary>
    public float Shrink { get; set; } = 1;
}

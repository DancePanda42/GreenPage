namespace GreenPage.Shared.Models;

/// <summary>
///     Represent the css flex positions.
/// </summary>
[Flags]
public enum FlexPosition
{
#pragma warning disable format
    Center =    0b0000_0001,
    Start =     0b0000_0010,
    Top =       0b0000_0100,
    End =       0b0000_1000,
    Bottom =    0b0001_0000,
}
#pragma warning restore format


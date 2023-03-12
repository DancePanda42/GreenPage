namespace GreenPage.Shared.Models;

/// <summary>
///     The available types that can be rendered.
/// </summary>
public enum RenderType
{
    //layout
    Page,
    Columns,
    Rows,
    Accordion,

    // Container
    Blog,

    // container items
    Text,
    
    Image,
    ImageWithText,
    
    Video,
    VideoWithText,

    ImageSlider,
    ContentSlider,

    Link,
}

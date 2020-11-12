namespace BlazorCssPlayground.Models
{
    public class PlaygroundModel
    {
        public string CssValue { get; set; } =
            ".display-container {" + System.Environment.NewLine +
            "    display: grid;" + System.Environment.NewLine +
            "}" + System.Environment.NewLine + System.Environment.NewLine +
            ".display-container * {" + System.Environment.NewLine +
            "    margin: 0.25rem;" + System.Environment.NewLine +
            "}";

        public string HtmlValue { get; set; } =
            "<section>Section 1</section>" + System.Environment.NewLine +
            "<section>Section 2</section>" + System.Environment.NewLine +
            "<section>Section 3</section>";
    }
}
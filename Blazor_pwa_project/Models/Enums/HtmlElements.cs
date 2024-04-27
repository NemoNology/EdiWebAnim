using WebAnimEdit.Models.Implementations;
using Attribute = WebAnimEdit.Models.Implementations.Attribute;

namespace WebAnimEdit.Models.Enums
{
    public static class HtmlElements
    {
        public static List<Attribute> DivisionAttributes =>
            new()
            {
                Attributes.Text,
                Attributes.FontSize,
                Attributes.FontFamily,
                Attributes.FontStyle,
                Attributes.FontWeight,
                Attributes.FontColor,
                Attributes.BackgroundColor,
                Attributes.Padding,
                Attributes.Margin,
                Attributes.BorderThickness,
                Attributes.BorderColor,
                Attributes.BorderStyle,
                Attributes.BorderCornerRadius,
                Attributes.PositionType,
                Attributes.PositionLeft,
                Attributes.PositionTop,
                Attributes.Width,
                Attributes.Height,
                Attributes.Rotation,
                Attributes.Scale,
                Attributes.Class,
                Attributes.Style,
                Attributes.AnimationStyle,
                Attributes.OnClick,
                Attributes.OnMouseOver,
                Attributes.OnMouseOut,
                Attributes.OnKeyDown
            };

        public static HtmlElement Division => new(
            "Разделитель",
            "div",
            DivisionAttributes);
        public static HtmlElement Image => new(
            "Изображение",
            "div",
            new()
            {
                Attributes.ImageSource,
                Attributes.BackgroundColor,
                Attributes.Padding,
                Attributes.Margin,
                Attributes.BorderThickness,
                Attributes.BorderColor,
                Attributes.BorderStyle,
                Attributes.BorderCornerRadius,
                Attributes.PositionType,
                Attributes.PositionLeft,
                Attributes.PositionTop,
                Attributes.Width,
                Attributes.Height,
                Attributes.Rotation,
                Attributes.Scale,
                Attributes.Class,
                Attributes.Style,
                Attributes.AnimationStyle,
                Attributes.OnClick,
                Attributes.OnMouseOver,
                Attributes.OnMouseOut,
                Attributes.OnKeyDown
            });
        public static HtmlElement Button => new(
            "Кнопка",
            "button",
            DivisionAttributes);
        public static HtmlElement Html => new(
            "HTML-документ",
            "html",
            DivisionAttributes)
        {
            Children = new()
                {
                    Style,
                    new("Тело документа", "body", DivisionAttributes),
                    JSScript
                }
        };
        public static HtmlElement Style => new(
            "Таблица стилей",
            "style",
            new() {
                Attributes.StyleSheet
            });
        public static HtmlElement JSScript => new(
            "JavaScript скрипт",
            "script",
            new() {
                Attributes.Script
            });
    }
}
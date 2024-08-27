using System.Collections.Generic;

namespace HtmlHelpers;
internal class TagBuilder
{    
    private List<KeyValuePair<string, string>> cssRules = [];
    private readonly string tag;
    private readonly string innerHtml;

    /// <summary>
    /// Initializes a new instance of the <see cref="TagBuilder"/> class
    /// </summary>
    /// <param name="tag">Name of a tag (div, span, a, p, etc...)</param>
    /// <param name="innerHtml">Text inside the tag (<span>innerHtml</span>span></param>
    public TagBuilder(string tag, string innerHtml)
    {
        this.tag = tag;
        this.innerHtml = innerHtml;
    }

    public string Build() {

        string styles = "";

        foreach (KeyValuePair<string, string> tag in cssRules) {
            styles += $"{tag.Key}:{tag.Value};";
        }

        styles = "style=\"" + styles + "\"";

        string html = $"<{tag} {styles}>{innerHtml}</{tag}>";

        return html;
    }

    /// <summary>
    /// Adds align-content style
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AlignContent(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("align-content", value));
            return this;
        }
    }

    /// <summary>
    /// Adds align-items tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AlignItems(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("align-items", value));
            return this;
        }
    }

    /// <summary>
    /// Adds align-self tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AlignSelf(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("align-self", value));
            return this;
        }
    }

    /// <summary>
    /// Adds all tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder All(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("all", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Animation(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-delay tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationDelay(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-delay", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-direction tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationDirection(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-direction", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-duration tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationDuration(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-duration", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-fill-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationFillMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-fill-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-iteration-count tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationIterationCount(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-iteration-count", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-name tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationName(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-name", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-play-state tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationPlayState(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-play-state", value));
            return this;
        }
    }

    /// <summary>
    /// Adds animation-timing-function tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AnimationTimingFunction(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("animation-timing-function", value));
            return this;
        }
    }

    /// <summary>
    /// Adds aspect-ratio tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder AspectRatio(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("aspect-ratio", value));
            return this;
        }
    }

    /// <summary>
    /// Adds backdrop-filter tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackdropFilter(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("backdrop-filter", value));
            return this;
        }
    }

    /// <summary>
    /// Adds backface-visibility tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackfaceVisibility(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("backface-visibility", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Background(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-attachment tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundAttachment(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-attachment", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-blend-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundBlendMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-blend-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-clip tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundClip(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-clip", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-image tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundImage(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-image", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-origin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundOrigin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-origin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-repeat tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundRepeat(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-repeat", value));
            return this;
        }
    }

    /// <summary>
    /// Adds background-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BackgroundSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("background-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds block-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BlockSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("block-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Border(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-end-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockEndColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-end-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-end-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockEndStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-end-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-end-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockEndWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-end-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-start-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockStartColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-start-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-start-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockStartStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-start-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-start-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockStartWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-start-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-block-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBlockWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-block-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottomColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom-left-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottomLeftRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom-left-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom-right-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottomRightRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom-right-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottomStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-bottom-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderBottomWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-bottom-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-collapse tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderCollapse(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-collapse", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-end-end-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderEndEndRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-end-end-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-end-start-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderEndStartRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-end-start-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImage(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image-outset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImageOutset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image-outset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image-repeat tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImageRepeat(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image-repeat", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image-slice tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImageSlice(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image-slice", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image-source tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImageSource(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image-source", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-image-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderImageWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-image-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-end-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineEndColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-end-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-end-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineEndStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-end-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-end-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineEndWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-end-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-start-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineStartColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-start-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-start-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineStartStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-start-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-start-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineStartWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-start-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-inline-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderInlineWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-inline-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderLeft(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-left-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderLeftColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-left-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-left-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderLeftStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-left-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-left-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderLeftWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-left-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderRight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-right-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderRightColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-right-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-right-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderRightStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-right-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-right-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderRightWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-right-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-spacing tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderSpacing(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-spacing", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-start-end-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderStartEndRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-start-end-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-start-start-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderStartStartRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-start-start-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTopColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top-left-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTopLeftRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top-left-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top-right-radius tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTopRightRadius(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top-right-radius", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTopStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-top-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderTopWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-top-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds border-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BorderWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("border-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Bottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds box-decoration-break tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BoxDecorationBreak(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("box-decoration-break", value));
            return this;
        }
    }

    /// <summary>
    /// Adds box-shadow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BoxShadow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("box-shadow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds box-sizing tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BoxSizing(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("box-sizing", value));
            return this;
        }
    }

    /// <summary>
    /// Adds break-after tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BreakAfter(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("break-after", value));
            return this;
        }
    }

    /// <summary>
    /// Adds break-before tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BreakBefore(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("break-before", value));
            return this;
        }
    }

    /// <summary>
    /// Adds break-inside tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder BreakInside(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("break-inside", value));
            return this;
        }
    }

    /// <summary>
    /// Adds caption-side tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder CaptionSide(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("caption-side", value));
            return this;
        }
    }

    /// <summary>
    /// Adds caret-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder CaretColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("caret-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds clear tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Clear(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("clear", value));
            return this;
        }
    }

    /// <summary>
    /// Adds clip tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Clip(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("clip", value));
            return this;
        }
    }

    /// <summary>
    /// Adds clip-path tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ClipPath(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("clip-path", value));
            return this;
        }
    }

    /// <summary>
    /// Adds color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Color(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-count tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnCount(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-count", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-fill tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnFill(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-fill", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnGap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-rule tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnRule(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-rule", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-rule-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnRuleColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-rule-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-rule-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnRuleStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-rule-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-rule-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnRuleWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-rule-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-span tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnSpan(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-span", value));
            return this;
        }
    }

    /// <summary>
    /// Adds column-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ColumnWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("column-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds columns tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Columns(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("columns", value));
            return this;
        }
    }

    /// <summary>
    /// Adds content tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Content(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("content", value));
            return this;
        }
    }

    /// <summary>
    /// Adds counter-increment tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder CounterIncrement(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("counter-increment", value));
            return this;
        }
    }

    /// <summary>
    /// Adds counter-reset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder CounterReset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("counter-reset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds cursor tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Cursor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("cursor", value));
            return this;
        }
    }

    /// <summary>
    /// Adds direction tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Direction(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("direction", value));
            return this;
        }
    }

    /// <summary>
    /// Adds display tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Display(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("display", value));
            return this;
        }
    }

    /// <summary>
    /// Adds empty-cells tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder EmptyCells(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("empty-cells", value));
            return this;
        }
    }

    /// <summary>
    /// Adds filter tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Filter(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("filter", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Flex(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-basis tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexBasis(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-basis", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-direction tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexDirection(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-direction", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-flow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexFlow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-flow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-grow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexGrow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-grow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-shrink tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexShrink(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-shrink", value));
            return this;
        }
    }

    /// <summary>
    /// Adds flex-wrap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FlexWrap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("flex-wrap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds float tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Float(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("float", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Font(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-family tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontFamily(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-family", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-feature-settings tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontFeatureSettings(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-feature-settings", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-kerning tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontKerning(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-kerning", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-optical-sizing tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontOpticalSizing(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-optical-sizing", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-size-adjust tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontSizeAdjust(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-size-adjust", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-stretch tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontStretch(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-stretch", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-synthesis tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontSynthesis(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-synthesis", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariant(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-alternates tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantAlternates(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-alternates", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-caps tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantCaps(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-caps", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-east-asian tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantEastAsian(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-east-asian", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-ligatures tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantLigatures(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-ligatures", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-numeric tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantNumeric(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-numeric", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-variant-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontVariantPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-variant-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds font-weight tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder FontWeight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("font-weight", value));
            return this;
        }
    }

    /// <summary>
    /// Adds gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Gap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Grid(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-area tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridArea(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-area", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-auto-columns tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridAutoColumns(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-auto-columns", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-auto-flow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridAutoFlow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-auto-flow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-auto-rows tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridAutoRows(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-auto-rows", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-column tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridColumn(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-column", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-column-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridColumnEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-column-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-column-gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridColumnGap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-column-gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-column-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridColumnStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-column-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridGap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-row tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridRow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-row", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-row-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridRowEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-row-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-row-gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridRowGap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-row-gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-row-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridRowStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-row-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-template tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridTemplate(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-template", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-template-areas tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridTemplateAreas(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-template-areas", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-template-columns tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridTemplateColumns(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-template-columns", value));
            return this;
        }
    }

    /// <summary>
    /// Adds grid-template-rows tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder GridTemplateRows(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("grid-template-rows", value));
            return this;
        }
    }

    /// <summary>
    /// Adds hanging-punctuation tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder HangingPunctuation(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("hanging-punctuation", value));
            return this;
        }
    }

    /// <summary>
    /// Adds height tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Height(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("height", value));
            return this;
        }
    }

    /// <summary>
    /// Adds hyphens tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Hyphens(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("hyphens", value));
            return this;
        }
    }

    /// <summary>
    /// Adds image-rendering tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ImageRendering(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("image-rendering", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inline-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InlineSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inline-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Inset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds inset-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder InsetInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("inset-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds isolation tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Isolation(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("isolation", value));
            return this;
        }
    }

    /// <summary>
    /// Adds justify-content tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder JustifyContent(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("justify-content", value));
            return this;
        }
    }

    /// <summary>
    /// Adds justify-items tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder JustifyItems(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("justify-items", value));
            return this;
        }
    }

    /// <summary>
    /// Adds justify-self tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder JustifySelf(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("justify-self", value));
            return this;
        }
    }

    /// <summary>
    /// Adds left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Left(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds letter-spacing tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder LetterSpacing(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("letter-spacing", value));
            return this;
        }
    }

    /// <summary>
    /// Adds line-break tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder LineBreak(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("line-break", value));
            return this;
        }
    }

    /// <summary>
    /// Adds line-height tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder LineHeight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("line-height", value));
            return this;
        }
    }

    /// <summary>
    /// Adds list-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ListStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("list-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds list-style-image tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ListStyleImage(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("list-style-image", value));
            return this;
        }
    }

    /// <summary>
    /// Adds list-style-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ListStylePosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("list-style-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds list-style-type tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ListStyleType(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("list-style-type", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Margin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginBottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginLeft(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginRight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds margin-top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MarginTop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("margin-top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Mask(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorder(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-outset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderOutset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-outset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-repeat tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderRepeat(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-repeat", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-slice tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderSlice(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-slice", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-source tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderSource(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-source", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-border-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskBorderWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-border-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-clip tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskClip(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-clip", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-composite tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskComposite(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-composite", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-image tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskImage(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-image", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-origin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskOrigin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-origin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-repeat tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskRepeat(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-repeat", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mask-type tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaskType(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mask-type", value));
            return this;
        }
    }

    /// <summary>
    /// Adds max-block-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaxBlockSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("max-block-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds max-height tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaxHeight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("max-height", value));
            return this;
        }
    }

    /// <summary>
    /// Adds max-inline-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaxInlineSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("max-inline-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds max-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MaxWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("max-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds min-block-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MinBlockSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("min-block-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds min-height tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MinHeight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("min-height", value));
            return this;
        }
    }

    /// <summary>
    /// Adds min-inline-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MinInlineSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("min-inline-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds min-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MinWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("min-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds mix-blend-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder MixBlendMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("mix-blend-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds object-fit tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ObjectFit(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("object-fit", value));
            return this;
        }
    }

    /// <summary>
    /// Adds object-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ObjectPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("object-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds offset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Offset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("offset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds offset-anchor tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OffsetAnchor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("offset-anchor", value));
            return this;
        }
    }

    /// <summary>
    /// Adds offset-distance tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OffsetDistance(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("offset-distance", value));
            return this;
        }
    }

    /// <summary>
    /// Adds offset-path tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OffsetPath(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("offset-path", value));
            return this;
        }
    }

    /// <summary>
    /// Adds offset-rotate tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OffsetRotate(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("offset-rotate", value));
            return this;
        }
    }

    /// <summary>
    /// Adds opacity tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Opacity(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("opacity", value));
            return this;
        }
    }

    /// <summary>
    /// Adds order tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Order(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("order", value));
            return this;
        }
    }

    /// <summary>
    /// Adds orphans tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Orphans(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("orphans", value));
            return this;
        }
    }

    /// <summary>
    /// Adds outline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Outline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("outline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds outline-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OutlineColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("outline-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds outline-offset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OutlineOffset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("outline-offset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds outline-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OutlineStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("outline-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds outline-width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OutlineWidth(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("outline-width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Overflow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-anchor tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowAnchor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-anchor", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-clip-margin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowClipMargin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-clip-margin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-wrap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowWrap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-wrap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-x tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowX(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-x", value));
            return this;
        }
    }

    /// <summary>
    /// Adds overflow-y tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder OverflowY(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("overflow-y", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Padding(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingBottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingLeft(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingRight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds padding-top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PaddingTop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("padding-top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds page-break-after tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PageBreakAfter(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("page-break-after", value));
            return this;
        }
    }

    /// <summary>
    /// Adds page-break-before tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PageBreakBefore(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("page-break-before", value));
            return this;
        }
    }

    /// <summary>
    /// Adds page-break-inside tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PageBreakInside(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("page-break-inside", value));
            return this;
        }
    }

    /// <summary>
    /// Adds perspective tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Perspective(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("perspective", value));
            return this;
        }
    }

    /// <summary>
    /// Adds perspective-origin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PerspectiveOrigin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("perspective-origin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds place-content tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PlaceContent(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("place-content", value));
            return this;
        }
    }

    /// <summary>
    /// Adds place-items tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PlaceItems(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("place-items", value));
            return this;
        }
    }

    /// <summary>
    /// Adds place-self tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PlaceSelf(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("place-self", value));
            return this;
        }
    }

    /// <summary>
    /// Adds pointer-events tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PointerEvents(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("pointer-events", value));
            return this;
        }
    }

    /// <summary>
    /// Adds position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Position(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds print-color-adjust tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder PrintColorAdjust(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("print-color-adjust", value));
            return this;
        }
    }

    /// <summary>
    /// Adds quotes tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Quotes(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("quotes", value));
            return this;
        }
    }

    /// <summary>
    /// Adds resize tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Resize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("resize", value));
            return this;
        }
    }

    /// <summary>
    /// Adds right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Right(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds rotate tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Rotate(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("rotate", value));
            return this;
        }
    }

    /// <summary>
    /// Adds row-gap tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder RowGap(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("row-gap", value));
            return this;
        }
    }

    /// <summary>
    /// Adds ruby-align tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder RubyAlign(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("ruby-align", value));
            return this;
        }
    }

    /// <summary>
    /// Adds ruby-merge tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder RubyMerge(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("ruby-merge", value));
            return this;
        }
    }

    /// <summary>
    /// Adds ruby-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder RubyPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("ruby-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scale tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Scale(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scale", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-behavior tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollBehavior(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-behavior", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMargin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginBottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginLeft(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginRight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-margin-top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollMarginTop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-margin-top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPadding(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-block tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingBlock(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-block", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-block-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingBlockEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-block-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-block-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingBlockStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-block-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-bottom tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingBottom(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-bottom", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-inline tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingInline(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-inline", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-inline-end tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingInlineEnd(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-inline-end", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-inline-start tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingInlineStart(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-inline-start", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-left tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingLeft(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-left", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-right tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingRight(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-right", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-padding-top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollPaddingTop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-padding-top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-snap-align tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollSnapAlign(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-snap-align", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-snap-stop tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollSnapStop(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-snap-stop", value));
            return this;
        }
    }

    /// <summary>
    /// Adds scroll-snap-type tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ScrollSnapType(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("scroll-snap-type", value));
            return this;
        }
    }

    /// <summary>
    /// Adds shape-image-threshold tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ShapeImageThreshold(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("shape-image-threshold", value));
            return this;
        }
    }

    /// <summary>
    /// Adds shape-margin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ShapeMargin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("shape-margin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds shape-outside tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ShapeOutside(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("shape-outside", value));
            return this;
        }
    }

    /// <summary>
    /// Adds tab-size tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TabSize(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("tab-size", value));
            return this;
        }
    }

    /// <summary>
    /// Adds table-layout tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TableLayout(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("table-layout", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-align tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextAlign(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-align", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-align-last tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextAlignLast(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-align-last", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-combine-upright tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextCombineUpright(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-combine-upright", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecoration(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecorationColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration-line tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecorationLine(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration-line", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration-skip tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecorationSkip(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration-skip", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration-skip-ink tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecorationSkipInk(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration-skip-ink", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-decoration-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextDecorationStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-decoration-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-emphasis tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextEmphasis(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-emphasis", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-emphasis-color tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextEmphasisColor(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-emphasis-color", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-emphasis-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextEmphasisPosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-emphasis-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-emphasis-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextEmphasisStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-emphasis-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-indent tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextIndent(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-indent", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-justify tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextJustify(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-justify", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-orientation tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextOrientation(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-orientation", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-overflow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextOverflow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-overflow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-rendering tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextRendering(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-rendering", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-shadow tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextShadow(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-shadow", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-transform tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextTransform(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-transform", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-underline-offset tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextUnderlineOffset(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-underline-offset", value));
            return this;
        }
    }

    /// <summary>
    /// Adds text-underline-position tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TextUnderlinePosition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("text-underline-position", value));
            return this;
        }
    }

    /// <summary>
    /// Adds top tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Top(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("top", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transform tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Transform(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transform", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transform-box tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransformBox(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transform-box", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transform-origin tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransformOrigin(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transform-origin", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transform-style tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransformStyle(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transform-style", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transition tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Transition(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transition", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transition-delay tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransitionDelay(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transition-delay", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transition-duration tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransitionDuration(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transition-duration", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transition-property tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransitionProperty(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transition-property", value));
            return this;
        }
    }

    /// <summary>
    /// Adds transition-timing-function tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder TransitionTimingFunction(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("transition-timing-function", value));
            return this;
        }
    }

    /// <summary>
    /// Adds unicode-bidi tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder UnicodeBidi(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("unicode-bidi", value));
            return this;
        }
    }

    /// <summary>
    /// Adds user-select tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder UserSelect(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("user-select", value));
            return this;
        }
    }

    /// <summary>
    /// Adds vertical-align tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder VerticalAlign(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("vertical-align", value));
            return this;
        }
    }

    /// <summary>
    /// Adds visibility tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Visibility(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("visibility", value));
            return this;
        }
    }

    /// <summary>
    /// Adds white-space tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder WhiteSpace(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("white-space", value));
            return this;
        }
    }

    /// <summary>
    /// Adds widows tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Widows(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("widows", value));
            return this;
        }
    }

    /// <summary>
    /// Adds width tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder Width(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("width", value));
            return this;
        }
    }

    /// <summary>
    /// Adds will-change tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder WillChange(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("will-change", value));
            return this;
        }
    }

    /// <summary>
    /// Adds word-break tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder WordBreak(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("word-break", value));
            return this;
        }
    }

    /// <summary>
    /// Adds word-spacing tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder WordSpacing(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("word-spacing", value));
            return this;
        }
    }

    /// <summary>
    /// Adds writing-mode tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder WritingMode(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("writing-mode", value));
            return this;
        }
    }

    /// <summary>
    /// Adds z-index tag
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Instance</returns>
    public TagBuilder ZIndex(string value) {
        {
            cssRules.Add(new KeyValuePair<string, string>("z-index", value));
            return this;
        }
    }



}

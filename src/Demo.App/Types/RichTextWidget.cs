using Our.Umbraco.Ditto.Resolvers.Archetype.Attributes;

namespace Demo.App.Types
{
    [ArchetypeContent(alias: "richText")]
    public class RichTextWidget
    {
        [ArchetypeValueResolver(alias: "text")]
        public string Text { get; set; }
    }
}
using Demo.App.Interfaces;
using Our.Umbraco.Ditto.Resolvers.Archetype.Attributes;
using System.Collections.Generic;

namespace Demo.App.Compositions
{
    public class TypicalComposition
    {
        [ArchetypeValueResolver(alias: "mainContent")]
        public List<IWidget> MainContent { get; set; }
    }
}
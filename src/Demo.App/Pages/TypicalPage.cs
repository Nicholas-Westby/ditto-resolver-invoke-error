using Demo.App.Compositions;
using Our.Umbraco.Ditto;

namespace Demo.App.Pages
{
    public class TypicalPage
    {
        [CurrentContentAs]
        public TypicalComposition Typical { get; set; }
    }
}
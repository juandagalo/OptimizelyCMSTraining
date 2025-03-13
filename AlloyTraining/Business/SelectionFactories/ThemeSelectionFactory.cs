using EPiServer.Shell.ObjectEditing;

namespace AlloyTraining.Business.SelectionFactories
{
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem { Value = "theme1", Text = "Orange" };
            yield return new SelectItem { Value = "theme2", Text = "Purble" };
            yield return new SelectItem { Value = "theme3", Text = "Geen" };
        }
    }
}

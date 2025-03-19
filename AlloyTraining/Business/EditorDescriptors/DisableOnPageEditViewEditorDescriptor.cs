using EPiServer.Shell;

namespace AlloyTraining.Business.EditorDescriptors
{
    [UIDescriptorRegistration]
    public class DisableOnPageEditViewEditorDescriptor : UIDescriptor<IDisableOnPageEditView>
    {
        public DisableOnPageEditViewEditorDescriptor()
        {
            DisabledViews =
                [
                    CmsViewNames.OnPageEditView,
                    CmsViewNames.PreviewView,
                    CmsViewNames.ContentListingView
                ];

            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}

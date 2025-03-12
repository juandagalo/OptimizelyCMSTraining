using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Portable Document Format",
        GUID = "{B078FFAF-FE2A-45DE-8286-EC93BF71F88B}",
        Description = "Use this to upload PDF files.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PdfFile : ImageData
    {
        public virtual bool RenderPreviewImage { get; set; }
    }
}

using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(
        DisplayName = "Image File",
        GUID = "{C1133DE1-0F1F-4015-B614-5BAC34F11400}",
        Description = "Used to upload image type media.")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,png")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}

using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "SVG File", 
        GUID = "{E79AEB70-3FD5-4087-9F45-09ED8631B4FC}",
        Description = "Use this to upload Scalable Vector Graphic (SVG)")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        public override Blob Thumbnail { get => base.Thumbnail;}
    }
}

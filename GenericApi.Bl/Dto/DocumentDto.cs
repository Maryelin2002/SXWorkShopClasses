using GenericApi.Core.BaseModel;

namespace GenericApi.Bl.Dto
{
    public class DocumentDto : BaseEntityDto
    {
        public string FileName { get; set; } //file-store name
        public string OriginalName { get; set; } //selected file
        public string ContentType { get; set; }
    }
}

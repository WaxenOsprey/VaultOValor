namespace models
{
    public class ContentTag
    {
        public int ContentTagId { get; set; }
        public int ContentId { get; set; }
        public int TagId { get; set; }

        public ContentTag(int contentTagId, int contentId, int tagId)
        {
            ContentTagId = contentTagId;
            ContentId = contentId;
            TagId = tagId;
        }
    }
}
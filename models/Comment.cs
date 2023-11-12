namespace models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int ContentId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public string CommentDate { get; set; }

        public Comment(int commentId, int contentId, int userId, string commentText, string commentDate)
        {
            CommentId = commentId;
            ContentId = contentId;
            UserId = userId;
            CommentText = commentText;
            CommentDate = commentDate;
        }
    }
}
namespace models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public int GameId { get; set; }
        public int PartyId { get; set; }
        public int PlayerId { get; set; }

        public Content(int contentId, string title, string filePath, string description, int gameId, int partyId, int playerId)
        {
            ContentId = contentId;
            Title = title;
            FilePath = filePath;
            Description = description;
            GameId = gameId;
            PartyId = partyId;
            PlayerId = playerId;
        }

    }
}
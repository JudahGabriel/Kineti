namespace KinetiComments.Models
{
    /// <summary>
    /// A comment on a blog post.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// The document ID of the comment.
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// The message of the comment.
        /// </summary>
        public required string Message { get; set; }

        /// <summary>
        /// The display name of the author, e.g. "Judah Gabriel"
        /// </summary>
        public required string Author { get; set; }

        /// <summary>
        /// The ID of the post that this comment is in reply to.
        /// </summary>
        public required string PostId { get; set; }

        /// <summary>
        /// The Disqus user name, e.g. "judahgabriel". This will be null if the comment is anonymous.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Whether the comment was posted anonymously.
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// The ID of the parent comment that this comment is in reply to. Will be null if not in reply to any comment.
        /// </summary>
        public string? ParentId { get; set; }

        /// <summary>
        /// Whether the comment has been classified as spam.
        /// </summary>
        public bool IsSpam { get; set; }

        /// <summary>
        /// Whether the comment has been deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}

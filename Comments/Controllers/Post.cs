namespace KinetiComments.Controllers
{
    /// <summary>
    /// A blog post. 
    /// </summary>
    public class Post
    {
        /// <summary>
        /// The document ID of the post.
        /// </summary>
        public required string Id { get; set; }

        /// <summary>
        /// The post title.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// The URL to the post.
        /// </summary>
        public required Uri Url { get; set; }

        /// <summary>
        /// The date the post was created.
        /// </summary>
        public DateTimeOffset Created { get; set; }
    }
}

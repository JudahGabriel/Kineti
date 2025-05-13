using KinetiComments.Models;
using Microsoft.AspNetCore.Mvc;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;

namespace KinetiComments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController
    {
        private readonly ILogger<CommentsController> logger;
        private readonly IAsyncDocumentSession dbSession;

        public CommentsController(IAsyncDocumentSession dbSession, ILogger<CommentsController> logger)
        {
            this.dbSession = dbSession;
            this.logger = logger;
        }

        [HttpGet("getComments")]
        public async Task<List<Comment>> GetComments(Uri postUrl)
        {
            // See if we have a Post with that URL.
            var post = await dbSession.Query<Post>()
                .FirstOrDefaultAsync(p => p.Url == postUrl);
            if (post == null)
            {
                return [];
            }

            // Find the comments for that post.
            var comments = await dbSession.Query<Comment>()
                .Where(c => c.PostId == post.Id)
                .ToListAsync();
            return comments;
        }
    }
}

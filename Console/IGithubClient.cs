using RestEase;
using System.Threading;
using System.Threading.Tasks;

namespace Samples
{
    [Header("User-Agent", "RestEase Sample")]
    public interface IGithubClient
    {
        [Get("users/{username}")]
        Task<GithubUser> GetUserAsync([Path("username")] string username, CancellationToken cancellationtoken);
    }
}

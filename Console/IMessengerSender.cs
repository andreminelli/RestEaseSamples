using RestEase;
using System.Threading;
using System.Threading.Tasks;

namespace Samples
{
    public interface IMessengerSender
    {
        [Post("me/messages")]
        Task<MessengerResponse> SendMessageAsync(
            [Body] MessengerRequest request,
            [Query("access_token}")] string accessToken,
            CancellationToken cancellationToken);
    }
}

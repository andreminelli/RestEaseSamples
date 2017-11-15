using RestEase;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var githubClient = RestClient.For<IGithubClient>("https://api.github.com");
                var user = await githubClient.GetUserAsync("takenet", CancellationToken.None);
                Console.WriteLine(user.Email);

                var messengerSender = RestClient.For<IMessengerSender>("https://graph.facebook.com/v2.6");
                var response = await messengerSender.SendMessageAsync(
                    new MessengerRequest
                    {
                        MessagingType = "UPDATE",
                        Recipient = new Recipient { Id = "xxxxxxxxxx" },
                        Message = new Message { Text = "Hello!" }
                    },
                    "<access token>",
                    CancellationToken.None);
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}

using Api.Chat.Models;
using Microsoft.AspNetCore.SignalR;

namespace Api.Chat.Hubs
{
    public class HubProvider : Hub<IHubProvider>
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.ReceivedMessage(message);
        }
    }
}
namespace OpenSDK.NEL.HandleWebSocket;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.WebSockets;

internal interface IWsHandler
{
    Task ProcessAsync(System.Net.WebSockets.WebSocket ws, JsonElement root);
}

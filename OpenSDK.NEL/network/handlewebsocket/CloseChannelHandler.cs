namespace OpenSDK.NEL.HandleWebSocket;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;
using OpenSDK.NEL;

internal class CloseChannelHandler : IWsHandler
{
    public async Task ProcessAsync(System.Net.WebSockets.WebSocket ws, JsonElement root)
    {
        var serverId2 = root.TryGetProperty("serverId", out var sid2) ? sid2.GetString() : null;
        if (!string.IsNullOrWhiteSpace(serverId2) && AppState.Channels.TryRemove(serverId2, out var ch)) ch.Cts.Cancel();
        var items = AppState.Channels.Values.Select(cc => new { serverId = cc.ServerId, serverName = cc.ServerName, address = cc.Ip + ":" + cc.Port }).ToArray();
        var msg = JsonSerializer.Serialize(new { type = "channels", items });
        await ws.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg)), System.Net.WebSockets.WebSocketMessageType.Text, true, System.Threading.CancellationToken.None);
    }
}
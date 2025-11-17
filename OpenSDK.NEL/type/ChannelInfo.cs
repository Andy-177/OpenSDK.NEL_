namespace OpenSDK.NEL;
using System.Threading;

internal class ChannelInfo
{
    public string ServerId { get; set; } = string.Empty;
    public string ServerName { get; set; } = string.Empty;
    public string Ip { get; set; } = string.Empty;
    public int Port { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public CancellationTokenSource Cts { get; set; } = new CancellationTokenSource();
}
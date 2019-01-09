using UnityEngine;
using Mirror;
using Mirror.Transport;

public class IgnoranceNetworkManager : NetworkManager
{
	// The server address to bind to, use this one. You can set it in the Unity Inspector.
    // Mirror went though some massive rewrites so this is needed.
	public string m_IgnoranceServerAddress = "127.0.0.1";
    // The server port to bind to, use this one. You can set it in the Unity Inspector.
    // Mirror went though some massive rewrites so this is needed.
    public ushort m_IgnoranceServerPort = 7779;

    /// <summary>
    /// Initialize the transport for use with Mirror.
    /// </summary>
    public override void InitializeTransport()
    {
        // Do not call the following unless you want to use TCP and WebSockets.
        // base.InitializeTransport();

        transport = new IgnoranceTransport(m_IgnoranceServerAddress, m_IgnoranceServerPort, (ushort)maxConnections);
		
		// Note that this network manager will be locked to that IP address and port, this is due to NetworkManager getting
		// some TCP and WebSocket upgrades... So you cannot change the server host address at runtime.
		
        // Nothing more needs to be done. You're good to go.
    }

    // Rest of your code goes below...
}

using UnityEngine;
using System.COllections;

public class NetworkMenu: MonoBehavior
{
	public string ip = "127.0.0.1";
	public int portNumber = 7777;


	private bool connected = false;

	private void OnConnectedToServer()
	{
		connected = true;
	}

	private void OnServerInitalized()
	{
		connected = true;
	}

	private void OnDisconnectedFromServer()
	{
		connected = false;
	}

	private void OnGUI()
	{
		//Output # of connected clients for debugging
		GUILayout.Label("Connections: "+Network.connections.ToString());

		ip = GUILayout.TextField(connectionIP);
		int.TryParse(GUILayout.TextField(portNumber.ToString()), out portNumber); 

		if (GUILayout.Button("Connect"))
			Network.Connect(ip,portNumber);
		if(GUILayout.Button("Host"))
			Network.INitalizeServer(4,portNumber,true); //4 is max # of clients allowed

		else
			GUILayout.Label("Connections :" + Netowrk.connections.ToString());
	}
}
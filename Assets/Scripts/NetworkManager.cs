using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting");
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        //Debug.Log("Joined Lobby");
        //RoomOptions roomOptions = new RoomOptions();
        //roomOptions.MaxPlayers = 100;
        //roomOptions.IsVisible = true;
        //Debug.Log("Joined Lobby 2");
        PhotonNetwork.JoinOrCreateRoom("1",null,null);
        Debug.Log("Joined Lobby 3");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("JoinedRoom");
        PhotonNetwork.LoadLevel(1);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("CreatedRoom");
        base.OnCreatedRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log(message);
        base.OnJoinRandomFailed(returnCode, message);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log(message);
        base.OnCreateRoomFailed(returnCode, message);
    }
}

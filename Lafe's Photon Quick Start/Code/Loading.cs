using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("QUICKSTART_Menu");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogError("There was an error connecting to the set server. Cause: " + cause);
    }
}

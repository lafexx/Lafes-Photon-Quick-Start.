using Photon.Pun;

public class Menu : MonoBehaviourPunCallbacks
{
    private bool CreatingJoiningRoom;

    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void Play()
    {
        if (!CreatingJoiningRoom)
        {
            CreatingJoiningRoom = true;

            if (PhotonNetwork.CountOfRooms > 0)
            {
                PhotonNetwork.JoinRandomRoom();
            }
            else if (PhotonNetwork.CountOfRooms == 0)
            {
                PhotonNetwork.CreateRoom(null);
            }
        }
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("QUICKSTART_Game");
    }
}

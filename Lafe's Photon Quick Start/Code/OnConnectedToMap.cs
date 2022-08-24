using UnityEngine;
using Photon.Pun;

public class OnConnectedToMap : MonoBehaviour
{
    private void Start()
    {
        PlayerManager playermanager = PhotonNetwork.Instantiate("PlayerManager", Vector3.zero, Quaternion.identity).transform.GetComponent<PlayerManager>();
        playermanager.InstantiatePlayer();
    }
}

using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;

    private void Awake()
    {
        PV = transform.GetComponent<PhotonView>();
    }

    public void InstantiatePlayer()
    {
        if (PV.IsMine)
        {
            GameObject player = PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
        }
    }
}

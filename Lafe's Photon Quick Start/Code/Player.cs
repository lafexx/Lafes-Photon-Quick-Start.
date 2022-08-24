using UnityEngine;
using Photon.Pun;

// You can start programming your player behaviour in this script.

namespace Player
{
    public class Player : MonoBehaviour
    {
        PhotonView PV;

        private void Start()
        {
            PV = transform.GetComponent<PhotonView>();
        }
    }
}

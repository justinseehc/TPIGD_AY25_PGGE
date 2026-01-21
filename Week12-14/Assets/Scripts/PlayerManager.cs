using UnityEngine;
using PGGE;
using Photon.Pun;
using Photon.Realtime;

public class PlayerManager : MonoBehaviour
{
    public string mPlayerPrefabName;
    public PlayerSpawnPoints mSpawnPoints;

    [HideInInspector]
    public GameObject mGameObject;
    [HideInInspector]
    private ThirdPersonCamera mThirdPersonCamera;
}

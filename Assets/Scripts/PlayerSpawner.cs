using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPosition.transform.position, spawnPosition.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

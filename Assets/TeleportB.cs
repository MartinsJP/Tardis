using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportB : MonoBehaviour
{
    public GameObject Player;

    public void TeleportPlayer()
    {
        Player.transform.position = new Vector3(6, 1.2f, 6);
    }
}

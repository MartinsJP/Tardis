using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportA : MonoBehaviour
{
    public GameObject Player;

    public void TeleportPlayer()
    {
        Player.transform.position = new Vector3(5, 2.15f, 10);
    }
}

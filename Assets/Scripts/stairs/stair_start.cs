using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stair_start : MonoBehaviour
{
    public Transform teleportTargetL;
    public Transform teleportTargetR;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (PlayerPrefs.GetString("stair") == "L")
        {
            player.transform.position = teleportTargetL.position;
        }
        else if (PlayerPrefs.GetString("stair") == "R")
        {
            player.transform.position = teleportTargetR.position;
        }
        else
        {
            Debug.LogError("error of 'stair'");
        }
    }

}

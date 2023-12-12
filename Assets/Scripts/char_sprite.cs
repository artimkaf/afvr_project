using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_sprite : MonoBehaviour
{
    public RuntimeAnimatorController animator_0;
    public RuntimeAnimatorController animator_1;

    void Start()
    {
        if (PlayerPrefs.GetInt("player_id") == 1)
        {
            GetComponent<Animator>().runtimeAnimatorController = animator_1;
        }
        else
        {
            GetComponent<Animator>().runtimeAnimatorController = animator_0;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class char_change : MonoBehaviour
{


    public Sprite spriteWhen0; // Спрайт, когда переменная равна 1
    public Sprite spriteWhen1; // Спрайт, когда переменная равна 0

    public void Start()
    {
        if (!PlayerPrefs.HasKey("player_id"))
        {
            PlayerPrefs.SetInt("player_id", 0);
        }
        if (PlayerPrefs.GetInt("player_id") == 0)
        {
            GetComponent<Image>().sprite = spriteWhen0;
        }
        else
        {
            GetComponent<Image>().sprite = spriteWhen1;
        }
    }   

    public void OnClick()
    {
        int currentId = PlayerPrefs.GetInt("player_id");

        if (currentId == 0)
        {
            PlayerPrefs.SetInt("player_id", 1);
            
            GetComponent<Image>().sprite = spriteWhen1;
        }
        else
        {
            PlayerPrefs.SetInt("player_id", 0);

            GetComponent<Image>().sprite = spriteWhen0;
        }
    }
}

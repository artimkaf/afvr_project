using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_sprite : MonoBehaviour
{
    public RuntimeAnimatorController animator_0; //ссылка на пак с анимациями женского персонажа
    public RuntimeAnimatorController animator_1; //ссылка на пак с анимациями мужского персонажа

    void Start()
    {
        if (PlayerPrefs.GetInt("player_id") == 1) // если был выбран персонаж мужчина
        {
            GetComponent<Animator>().runtimeAnimatorController = animator_1; //пак анимаций персонажа смениться на пак с анимацииями мужского персонажа
        }
        else
        {
            GetComponent<Animator>().runtimeAnimatorController = animator_0; //пак анимаций персонажа смениться на пак с анимацииями женского персонажа
        }
    }
}


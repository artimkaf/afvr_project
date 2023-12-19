using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stair_scene : MonoBehaviour
{
    public GameObject down_button;
    public GameObject up_button;
    public GameObject back_button;
    public GameObject fade;
    public GameObject fade_pp;
    void Start()
    {
        if (PlayerPrefs.GetInt("floor") > 2)
        {
            PlayerPrefs.SetInt("floor", 2);
        }
        if (PlayerPrefs.GetInt("floor") < 1)
        {
            PlayerPrefs.SetInt("floor", 1);
        }

        Debug.Log(PlayerPrefs.GetInt("floor"));

        if (PlayerPrefs.GetInt("floor") == 1)
        {
            down_button.SetActive(false);
            // сменить бекграунд
        }
        if (PlayerPrefs.GetInt("floor") == 2)
        {
            up_button.SetActive(false);
            // сменить бекграунд
        }
        // изменение спрайтов
        // скрипты перемещение на самих кнопках
    }

    // Update is called once per frame
    public void OnLeftTrigg()
    {
        fade.SetActive(true);
        int floor = PlayerPrefs.GetInt("floor");
        PlayerPrefs.SetInt("floor", floor + 1);
        Invoke("SceneUpdate", 0.8f);
    }
    public void OnRightTrigg()
    {
        fade.SetActive(true);
        int floor = PlayerPrefs.GetInt("floor");
        PlayerPrefs.SetInt("floor", floor - 1);
        Invoke("SceneUpdate", 0.8f);
    }
    public void OnBackTrigg()
    {
        fade_pp.SetActive(true);
        Invoke("SceneUpdate_pp", 0.8f);
    }
    void SceneUpdate()
    {
        SceneManager.LoadScene(3);
    }
    void SceneUpdate_pp()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("floor"));
    }
}

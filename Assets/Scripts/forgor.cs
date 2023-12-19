using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forgor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("stair", "J");
        PlayerPrefs.SetInt("floor", 1);
    }
    public void OnTrigg()
    {
        Invoke("SceneUpdate", 0.8f);
    }
    void SceneUpdate()
    {
        SceneManager.LoadScene(1);
    }
}

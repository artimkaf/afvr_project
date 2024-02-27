using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stair_end : MonoBehaviour
{   
    // public int WhereFloor;
    // public string WhereStair;

    public GameObject object_toggle; // Замените на нужный компонент вашего объекта
    public string side;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            object_toggle.SetActive(true);
            PlayerPrefs.SetString("stair", side);
            Invoke("SceneUpdate", 0.8f);
        }
    }
    void SceneUpdate()
    {
        SceneManager.LoadScene(6);
        
    }
}

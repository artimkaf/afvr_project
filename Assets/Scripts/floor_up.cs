using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floor_up : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены, на которую вы хотите перейти

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log('k');

        if (collision.CompareTag("Player")) // Проверяем, является ли столкнувшийся объект игроком
        {
            SceneManager.LoadScene(sceneToLoad); // Загружаем указанную сцену
        }
    }
}

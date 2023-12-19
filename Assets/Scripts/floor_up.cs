using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floor_up : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Проверяем, является ли столкнувшийся объект игроком
        {
            SceneManager.LoadScene(3); // Загружаем указанную сцену
        }
    }
}

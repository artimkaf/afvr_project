using UnityEngine;
using UnityEngine.UI;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleportTarget; // Целевая позиция, куда вы хотите телепортировать игрока

    void Start()
    {
        Button teleportButton = GetComponent<Button>(); // Получаем компонент кнопки
        teleportButton.onClick.AddListener(TeleportPlayerWithTag); // Добавляем слушатель для нажатия кнопки
    }

    void TeleportPlayerWithTag()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); // Находим объект с тегом "Player"
        
        if (player != null)
        {
            // Телепортируем игрока к целевой позиции
            player.transform.position = teleportTarget.position;
        }
        
    }
}

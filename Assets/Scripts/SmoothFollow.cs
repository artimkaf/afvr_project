using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target; // Объект, за которым будет следить камера
    public float smoothSpeed = 0.125f; // Скорость плавного следования камеры за объектом
    public Vector3 offset; // Смещение камеры относительно объекта

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Интерполяция для плавного движения
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z); // Оставляем z-координату камеры неизменной
        }
    }
}

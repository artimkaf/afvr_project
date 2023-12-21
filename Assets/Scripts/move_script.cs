using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float speed; // скорость персонажа
    private Rigidbody2D rb; //переменная Rigidbody2D

    public Animator animator; //ссылка на аниматор персонажа
    private Vector2 direction; //перменная с напрвлением персонажа

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); //ссылка на компонент Rigidbody2D
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal"); // координаты персонажа по оси X
        direction.y = Input.GetAxis("Vertical"); // координаты персонажа по оси Y
        
        animator.SetFloat("Horizontal", direction.x); // координаты анимации персонажа по оси X
        animator.SetFloat("Vertical", direction.y); // координаты анимации персонажа по оси Y
        animator.SetFloat("speed", direction.sqrMagnitude); // скорость анимации персонажа
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime); // функция которая передвигает персонажа
    }
}

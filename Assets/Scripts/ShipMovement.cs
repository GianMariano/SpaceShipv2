using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.0f;
    private float waitTime = 2.0f;
    private float speed = 1.0f;
    private float descentAmount = 0.01f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * speed; // Movimento para a esquerda
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            // Inimigos descem (agora no eixo Y) e invertem direção
            transform.position += Vector3.down * descentAmount;
            rb2d.velocity *= -1; // Inverte direção (esquerda/direita)
            timer = 0.0f;
        }
    }
}

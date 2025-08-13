using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Obtener entrada del usuario
        movement.x = Input.GetAxisRaw("Horizontal"); // A,D o teclas de flecha izquierda/derecha
        movement.y = Input.GetAxisRaw("Vertical"); ;   // W,S o teclas de flecha arriba/abajo
    }

    void FixedUpdate()
    {
        // Mover el personaje
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variabile per la velocità del Capybara (puoi cambiarla da Unity!)
    public float moveSpeed = 5f;
    
    // Il riferimento al "corpo fisico" del Capybara
    public Rigidbody2D rb;
    
    // Serve a memorizzare dove stiamo premendo
    private Vector2 movement;

    // L'Update legge i nostri comandi (Freccette o WASD) ad ogni fotogramma
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Il FixedUpdate si occupa di muovere fisicamente il corpo
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
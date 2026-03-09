using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Questo è il bersaglio da seguire (il nostro Capybara)
    public Transform target;
    
    // Questa è la distanza della telecamera (deve stare un po' "indietro" per inquadrare la scena)
    public Vector3 offset = new Vector3(0, 0, -10);

    // LateUpdate viene chiamato subito dopo che il Capybara si è mosso
    void LateUpdate()
    {
        if (target != null)
        {
            // Sposta la telecamera esattamente dove sta il Capybara, mantenendo la distanza
            transform.position = target.position + offset;
        }
    }
}
using UnityEngine;

public class ComportamentoUccellino : MonoBehaviour
{
    [Header("Impostazioni Radar")]
    public Transform reCapybara;         // Il bersaglio da controllare
    public float distanzaAttivazione = 3f; // Quanto vicino deve essere per muoversi

    private Animator anim;

    void Start()
    {
        // Prende l'Animator collegato a questo uccellino
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Controlla se abbiamo assegnato il Re Capybara
        if (reCapybara != null)
        {
            // Calcola la distanza tra l'uccellino e il giocatore
            float distanza = Vector2.Distance(transform.position, reCapybara.position);

            // Se il giocatore è più vicino della distanza impostata...
            if (distanza <= distanzaAttivazione)
            {
                anim.SetBool("Vicino", true);  // Accende l'animazione!
            }
            else
            {
                anim.SetBool("Vicino", false); // Spegne l'animazione, torna fermo.
            }
        }
    }
}
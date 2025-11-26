using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    private int hits = 0;  // Contador de impactos
    public void TakeDamage()
    {
        hits++;  // Incrementa el contador de hits
        Debug.Log("Hits recibidos: " + hits);  // Opcional: para depurar en la consola
        if (hits >= 3)
        {
            // Carga la escena de índice 0 (ajusta el índice si es necesario)
            SceneManager.LoadScene(0);
        }
    }
}
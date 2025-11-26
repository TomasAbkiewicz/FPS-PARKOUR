using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Obtiene el componente PlayerHealth del player
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                // Llama al método para recibir daño
                playerHealth.TakeDamage();
            }
            // Destruye el proyectil después del impacto
            Destroy(gameObject);
        }
    }
}
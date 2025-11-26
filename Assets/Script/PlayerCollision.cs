using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);  // Log para ver si entra aquí

        // Verifica si el objeto colisionado tiene el componente EnemyAI
        EnemyAI enemy = collision.gameObject.GetComponent<EnemyAI>();
        if (enemy != null)
        {
            Debug.Log("Enemigo detectado, destruyendo...");  // Log antes de destruir
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("No es un enemigo (no tiene EnemyAI)");  // Log si no es enemigo
        }
    }
}
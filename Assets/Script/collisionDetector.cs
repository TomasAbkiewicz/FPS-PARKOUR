using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        if(collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}

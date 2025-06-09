using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour
{
    public float damage = 5;
    public healthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<healthManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthManager.UpdateHealth(-damage))
            {
                Destroy(gameObject);
            }


        }
    }
}

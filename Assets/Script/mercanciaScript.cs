using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour
{
    public float cost = 5;
    public moneyManager moneyManager;

     void Start()
    {
        moneyManager = FindObjectOfType<moneyManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}

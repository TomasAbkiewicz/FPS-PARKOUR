using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManager : MonoBehaviour
{
    public float money;

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            // impedir compra
            Debug.Log("dinero insuficiente");
        }
        else
        {
            money += amount;
        }


    }
}

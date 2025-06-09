using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    public int healthPoints;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealth(int damageAmount)
    {
        if (healthPoints <= damageAmount)
        {
            // moriste
            Debug.Log("moriste");
            return false;
        }
        healthPoints -= damageAmount;
        UIManager.UpdateHealthText(healthPoints.ToString());
        return true;


    }
}

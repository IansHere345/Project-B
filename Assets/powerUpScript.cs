using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class powerUpScript : MonoBehaviour
{
    public bool healthPowerUp;
    public bool fireRatePowerUp;
    public int healthIncreaseAmount = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (healthPowerUp)
            {
                other.GetComponent<Health>().Heal(healthIncreaseAmount);
            }
            else if (fireRatePowerUp)
            {
                other.GetComponent<bulletScript>().ActiveFireRateBoost();
            }
            Destroy(gameObject);
        }
    }
}


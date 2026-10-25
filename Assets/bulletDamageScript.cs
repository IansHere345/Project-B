using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour
{
    public GameObject owner; //Ensures each player has their own distinct bullets
    public int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponentInParent<Health>();

        if (health != null &&
            health.gameObject != owner)
        {
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

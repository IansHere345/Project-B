using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bulletScript : MonoBehaviour
{
    [SerializeField] private float timer = 5f;
    private float bulletTime;

    public GameObject Bullet;
    public Transform SpawnPoint;
    public float playerSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletTime = timer;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(Bullet, SpawnPoint.position, SpawnPoint.rotation);
        BulletDamage bulletDamage = bulletObj.GetComponent<BulletDamage>();

        if (bulletDamage != null)
        {
        bulletDamage.owner = gameObject;
        }
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        if (bulletRig != null)
        {
        bulletRig.AddForce(SpawnPoint.forward * playerSpeed, ForceMode.Impulse);
        }
        Destroy(bulletObj, 5f);
    }
    private Coroutine fireRateCoroutine;
    public void ActiveFireRateBoost()
    {
        if (fireRateCoroutine != null)
        {
            StopCoroutine(fireRateCoroutine);
        }
        fireRateCoroutine = StartCoroutine(FireRateBoost());
    }
    IEnumerator FireRateBoost()
    {
        float originalTimer = timer;
        timer = originalTimer / 3f; // Triple the fire rate
        yield return new WaitForSeconds(5f); // Maintain the boosted fire rate for 5 seconds
        timer = originalTimer; // Reset to the original fire rate
        fireRateCoroutine = null;
    }
    //Source Used: https://youtu.be/k1kOtaM2NJg?si=jtRQW-slvA-X18Td
}

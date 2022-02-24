using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SCR_Revolver : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletForce = 10000f;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] public float currentAmmo = 0;
    [SerializeField] public float maxAmmo = 6;

    [SerializeField] private TextMeshProUGUI currentAmmoCount;
    [SerializeField] private TextMeshProUGUI maxAmmoCount;

    void Update()
    {
        currentAmmoCount.text = currentAmmo.ToString();
        maxAmmoCount.text = maxAmmo.ToString();

        if (Input.GetMouseButtonDown(0) && currentAmmo > 0)
        {
            Fire();
        }
    }

    void Fire()
    {
        currentAmmo--;

        GameObject bulletGO = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rb = bulletGO.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(transform.forward * bulletForce * Time.deltaTime);
        }
        Destroy(bulletGO, 10f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int maxAmmo = 10;
    private int currentAmmo;

	// Use this for initialization
	void Start () {
        currentAmmo = maxAmmo;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
    public void Shoot()
    {
        //This will create a game object copied from a prefab.
        currentAmmo--;

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform firePoint;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1")) Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}

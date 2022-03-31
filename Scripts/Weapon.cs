using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
	public GameObject bulletPrefab;
	private AudioSource ShootingSound;
	
	void Update () {
		if (Input.GetButtonDown("Vertical"))
		{
			Shoot();
		}
	}
	void Shoot ()
	{
		Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
	}
}

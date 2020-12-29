using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileShooter : MonoBehaviour, IPlayer
{
    public GameObject projectile;
    public Transform firePoint;

    [SerializeField] float speed = 1000f;

    private Camera playerCamera;

    void Start()
    {
        playerCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootProjectile();
        }
    }

    private void ShootProjectile()
    {
        GameObject projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        Rigidbody projectileRigidBody = projectileObj.GetComponent<Rigidbody>();
        projectileRigidBody.velocity = playerCamera.transform.forward * speed * Time.deltaTime;
        // TODO: Remove projectiles after a while that will not hit anything
    }
}

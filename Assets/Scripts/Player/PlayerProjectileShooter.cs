using UnityEngine;
using UnityEngine.VFX;
public class PlayerProjectileShooter : MonoBehaviour
{
    public GameObject projectile;
    public Transform firePoint;
    public VisualEffect muzzleEffect;

    [SerializeField] float speed = 1000f;

    public Camera playerCamera;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        ShootProjectile();
        ShowMuzzle();
    }

    private void ShootProjectile()
    {
        GameObject projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        Rigidbody projectileRigidBody = projectileObj.GetComponent<Rigidbody>();
        projectileRigidBody.velocity = playerCamera.transform.forward * speed * Time.deltaTime;
        // TODO: Remove projectiles after a while that will not hit anything
    }

    private void ShowMuzzle()
    {
        muzzleEffect.Play();
    }
}

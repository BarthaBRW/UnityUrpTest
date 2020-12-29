using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectile : MonoBehaviour
{
    public Transform impact;
    private bool collided;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Projectile" && collision.gameObject.tag != "Player" && !collided)
        {
            collided = true;
            InstantiateImpactObject(collision.contacts[0]);
            Destroy(gameObject);
        }
    }

    private void InstantiateImpactObject(ContactPoint contact)
    {
        Transform impactObj = Instantiate(impact, contact.point, Quaternion.identity) as Transform;
        impactObj.rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Destroy(impactObj.gameObject, 2f);
    }
}

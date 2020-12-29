using UnityEngine;

public class BasicProjectile : MonoBehaviour, IProjectile
{
    public Transform impact;
    private bool collided;
    void OnCollisionEnter(Collision collision)
    {
        if (!collided && !isProjectile(collision.gameObject) && !isPlayer(collision.gameObject))
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

    private bool isProjectile(GameObject gameObject)
    {
        return gameObject.GetComponent<IProjectile>() != null;
    }

    private bool isPlayer(GameObject gameObject)
    {
        return gameObject.GetComponent<Player>() != null;
    }
}

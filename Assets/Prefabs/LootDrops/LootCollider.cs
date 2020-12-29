using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootCollider : MonoBehaviour
{
    public event OnPickupDelegate OnPickupEvent;
    public delegate void OnPickupDelegate(Player player);

    void Setup()
    {
        enabled = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (!enabled)
        {
            return;
        }
        var player = collider.gameObject.GetComponent<Player>();
        if (player != null)
        {
            enabled = false;
            OnPickupEvent?.Invoke(player);
        }
    }
}

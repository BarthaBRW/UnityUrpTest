using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LootHandler : MonoBehaviour
{
    public LootCollider hitbox;
    void Start()
    {
        hitbox.OnPickupEvent += OnPickup;
    }

    private void OnPickup(Player player)
    {
        player.AddHealth(10f);
    }
}

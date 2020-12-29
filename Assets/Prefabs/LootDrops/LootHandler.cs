using UnityEngine;

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

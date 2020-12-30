using UnityEngine;

public class LootHandler : MonoBehaviour
{
    public LootCollider hitbox;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hitbox.OnPickupEvent += OnPickup;
    }

    private void OnPickup(Player player)
    {
        player.AddHealth(10f);
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LootVfxHandler : MonoBehaviour
{

    public LootCollider hitbox;
    private VisualEffect effect;

    void Start()
    {
        effect = GetComponent<VisualEffect>();
        hitbox.OnPickupEvent += OnPickup;
    }

    private void OnPickup(Player player)
    {
        effect.Stop();
        Destroy(gameObject.transform.parent.gameObject, 4f); // TODO: Remove only after VisualEffect duration
    }
}

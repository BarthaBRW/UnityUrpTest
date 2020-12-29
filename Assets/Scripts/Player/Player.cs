using UnityEngine;

public class Player : MonoBehaviour
{
    public event OnHealthChangedDelegate OnHealthChanged;
    public delegate void OnHealthChangedDelegate(float health);
    private static float MAX_HEALTH = 100f;
    private float health = MAX_HEALTH;

    public void AddHealth(float value)
    {
        health = Mathf.Clamp(health + value, 0, MAX_HEALTH);
        OnHealthChanged?.Invoke(health);
    }

    public float GetHealth()
    {
        return health;
    }
}

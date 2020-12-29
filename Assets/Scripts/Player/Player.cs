using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static float MAX_HEALTH = 100f;
    private float health;

    void Setup()
    {
        health = MAX_HEALTH;
    }

    public void AddHealth(float value)
    {
        print("Add health: " + value);
        health = Mathf.Clamp(health + value, 0, MAX_HEALTH);
    }
}

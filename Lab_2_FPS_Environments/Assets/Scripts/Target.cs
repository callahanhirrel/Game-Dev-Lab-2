using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 60f;
    public GameObject tar;

    public void Damage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Destroy(tar);
        }
    }
}

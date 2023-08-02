using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    public int damage;
    public float atkspd;
    public float range;
    public bool aoe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void takeDamage(int amount)
    {
        health -= amount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public float speed;
    public int health;
    public int damage;
    public float atkspd;
    public float range;
    public bool aoe;
    // Start is called before the first frame update
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

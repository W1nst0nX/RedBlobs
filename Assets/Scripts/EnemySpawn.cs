using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Unit;
    public float interval;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < interval)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            timer = 0;
        }
    }

    void spawnEnemy()
    {
        Instantiate(Unit, transform.position, transform.rotation);
    }
}

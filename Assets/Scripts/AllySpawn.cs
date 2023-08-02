using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawn : MonoBehaviour
{
    public GameObject Unit;
    // Start is called before the first frame update

    public void spawnAlly()
    {
        Instantiate(Unit, transform.position, transform.rotation);
    }
}

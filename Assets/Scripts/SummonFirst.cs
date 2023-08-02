using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonFirst : MonoBehaviour
{
    [SerializeField] GameController gC;
    [SerializeField] AllySpawn script;

    public void summonFirst()
    {
        if( gC.current > 200)
        {
            gC.current -= 200;
            script.spawnAlly();
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text money;
    private float max;
    public float current;
    private float increase;

    private void Awake()
    {
        Application.targetFrameRate = 45;
    }
    void Start()
    {
        current = 0;
        max = 10000;
        increase = 200;
        money.text = current + "/" + max;
    }

    // Update is called once per frame
    void Update()
    {
        if (current > max)
        {
            current = max;
        }
        current += increase * Time.deltaTime;
        money.text = Mathf.Floor(current) + "/" + Mathf.Floor(max);
    }

    public bool sendUnit(int amount)
    {
        if(current >= amount)
        {
            current -= amount;
            return true;
        }
        return false;
    }

    public void addCash(int amount)
    {
        if (current == max)
        {
            return;
        }
        else if(current + amount > max)
        {
            current = max;
        }
        else
        {
            current += amount;
        }
        
    }
}

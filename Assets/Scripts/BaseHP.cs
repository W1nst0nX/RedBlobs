using UnityEngine;
using UnityEngine.UI;

public class BaseHP : MonoBehaviour
{
    public int maxHP;
    private int currentHP;
    public bool dead;
    public Text text;

    void Start()
    {
        currentHP = maxHP;
        text.text = currentHP + " / " + maxHP;
        dead = false;
    }


    void Update()
    {
        if (currentHP <= 0 && dead == false)
        {
            Debug.Log("Died");
            dead = true;
        }
    }

    public void takeDamage(int amount)
    {
        if (!dead)
        {
            currentHP -= amount;
            text.text = currentHP + " / " + maxHP;
        }
    }
}

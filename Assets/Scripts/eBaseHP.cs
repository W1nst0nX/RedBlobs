using UnityEngine;
using UnityEngine.UI;

public class eBaseHP : MonoBehaviour
{
    public int maxHP;
    private int currentHP;
    public bool dead;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        text.text = currentHP + " / " + maxHP;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0 && dead == false)
        {
            Debug.Log("You Have Won");
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

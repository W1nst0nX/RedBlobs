using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class EndPanel : MonoBehaviour
{
    [SerializeField] BaseHP script;
    [SerializeField] eBaseHP script2;
    public GameObject endPanel;
    public TextMeshProUGUI endText;
    // Update is called once per frame

    private void Awake()
    {
        script = GameObject.Find("Base").GetComponent<BaseHP>();
        script2 = GameObject.Find("Enemy Base").GetComponent<eBaseHP>();
    }
    void Update()
    {
        if (script.dead)
        {
            endText.text = "DEFEAT";
            endPanel.SetActive(true);
            Time.timeScale = 0f;
            
        }
        else if (script2.dead)
        {
            endText.text = "VICTORY";
            endPanel.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Scene restarted");
        Time.timeScale = 1f;
    }
}

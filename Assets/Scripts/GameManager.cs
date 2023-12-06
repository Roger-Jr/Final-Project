using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject healthBar0, healthBar1, healthBar2, healthBar3, healthBar4, healthBar5, healthBar6, healthBar7, healthBar8, healthBar9;
    public TMP_Text healthBarText;
    public static int health;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        healthBar0.gameObject.SetActive(true);
        healthBar1.gameObject.SetActive(true);
        healthBar2.gameObject.SetActive(true);
        healthBar3.gameObject.SetActive(true);
        healthBar4.gameObject.SetActive(true);
        healthBar5.gameObject.SetActive(true);
        healthBar6.gameObject.SetActive(true);
        healthBar7.gameObject.SetActive(true);
        healthBar8.gameObject.SetActive(true);
        healthBar9.gameObject.SetActive(true);
        healthBarText.text = 100.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 10:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                healthBar6.gameObject.SetActive(true);
                healthBar7.gameObject.SetActive(true);
                healthBar8.gameObject.SetActive(true);
                healthBar9.gameObject.SetActive(true);
                healthBarText.text = 100.ToString("0");
                break;
            case 9:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                healthBar6.gameObject.SetActive(true);
                healthBar7.gameObject.SetActive(true);
                healthBar8.gameObject.SetActive(true);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 90.ToString("0");
                break;
            case 8:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                healthBar6.gameObject.SetActive(true);
                healthBar7.gameObject.SetActive(true);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 80.ToString("0");
                break;
            case 7:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                healthBar6.gameObject.SetActive(true);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 70.ToString("0");
                break;
            case 6:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 60.ToString("0");
                break;
            case 5:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 50.ToString("0");
                break;
            case 4:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 40.ToString("0");
                break;
            case 3:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 30.ToString("0");
                break;
            case 2:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 20.ToString("0");
                break;
            case 1:
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(false);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 10.ToString("0");
                break;
            default:
                healthBar0.gameObject.SetActive(false);
                healthBar1.gameObject.SetActive(false);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                healthBar6.gameObject.SetActive(false);
                healthBar7.gameObject.SetActive(false);
                healthBar8.gameObject.SetActive(false);
                healthBar9.gameObject.SetActive(false);
                healthBarText.text = 0.ToString("0");
                Time.timeScale = 0;
                SceneManager.LoadScene(sceneName);
                break;
        }
    }
}

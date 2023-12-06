using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZombieHealth1 : MonoBehaviour
{
    public GameObject player, zombie, healthBar0, healthBar1, healthBar2, healthBar3, healthBar4, healthBar5;
    public Transform healthBar;
    public static int health;
    // Start is called before the first frame update
    private void Start()
    {
        health = 6;
        healthBar0.gameObject.SetActive(true);
        healthBar1.gameObject.SetActive(true);
        healthBar2.gameObject.SetActive(true);
        healthBar3.gameObject.SetActive(true);
        healthBar4.gameObject.SetActive(true);
        healthBar5.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.LookAt(player.transform);
        switch (health)
        {
            case 6:
                health = 6;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(true);
                break;
            case 5:
                health = 5;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(true);
                healthBar5.gameObject.SetActive(false);
                break;
            case 4:
                health = 4;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(true);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                break;
            case 3:
                health = 3;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(true);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                break;
            case 2:
                health = 2;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(true);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                break;
            case 1:
                health = 1;
                healthBar0.gameObject.SetActive(true);
                healthBar1.gameObject.SetActive(false);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                break;
            case 0:
                health = 0;
                healthBar0.gameObject.SetActive(false);
                healthBar1.gameObject.SetActive(false);
                healthBar2.gameObject.SetActive(false);
                healthBar3.gameObject.SetActive(false);
                healthBar4.gameObject.SetActive(false);
                healthBar5.gameObject.SetActive(false);
                zombie.SetActive(false);
                break;
        }
    }
}

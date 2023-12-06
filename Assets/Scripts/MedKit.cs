using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    public GameObject medKit;
    public GameObject pistol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GunSwitcher.enableMedKit == true)
        {
            Healing();
        }
    }

    public void Healing()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameManager.health += 5;
            if (GameManager.health >= 10)
            {
                GameManager.health = 10;
            }
            GunSwitcher.enableMedKit = false;
            medKit.SetActive(false);
            pistol.SetActive(true);
        }
    }
}

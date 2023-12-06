using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMedKit : MonoBehaviour
{
    public GameObject superMedKit;
    public GameObject pistol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GunSwitcher.enableSuperMedKit == true)
        {
            Healing();
        }
    }

    public void Healing()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameManager.health += 10;
            if (GameManager.health >= 10)
            {
                GameManager.health = 10;
            }
            GunSwitcher.enableSuperMedKit = false;
            superMedKit.SetActive(false);
            pistol.SetActive(true);
        }
    }
}

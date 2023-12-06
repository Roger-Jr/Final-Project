using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    public GameObject medKit;
    public GameObject superMedKit;
    public static bool enableAssaultRifle = false;
    public static bool enableShotgun = false;
    public static bool enableMedKit = false;
    public static bool enableSuperMedKit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Equip1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (enableShotgun == true)
            {
                Equip2();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (enableAssaultRifle == true)
            {
                Equip3();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (enableMedKit == true)
            {
                Equip4();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (enableSuperMedKit == true)
            {
                Equip5();
            }
        }
    }

    public void Equip1()
    {
        gun1.SetActive(true);
        gun2.SetActive(false);
        gun3.SetActive(false);
        medKit.SetActive(false);
        superMedKit.SetActive(false);
    }
    public void Equip2()
    {
        gun1.SetActive(false);
        gun2.SetActive(true);
        gun3.SetActive(false);
        medKit.SetActive(false);
        superMedKit.SetActive(false);
    }
    public void Equip3()
    {
        gun1.SetActive(false);
        gun2.SetActive(false);
        gun3.SetActive(true);
        medKit.SetActive(false);
        superMedKit.SetActive(false);
    }
    public void Equip4()
    {
        gun1.SetActive(false);
        gun2.SetActive(false);
        gun3.SetActive(false);
        medKit.SetActive(true);
        superMedKit.SetActive(false);
    }
    public void Equip5()
    {
        gun1.SetActive(false);
        gun2.SetActive(false);
        gun3.SetActive(false);
        medKit.SetActive(false);
        superMedKit.SetActive(true);
    }
}

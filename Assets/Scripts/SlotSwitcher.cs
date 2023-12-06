using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSwitcher : MonoBehaviour
{
    public GameObject pistol;
    public GameObject pistolOutline;
    public GameObject shotgun;
    public GameObject shotgunOutline;
    public GameObject assaultRifle;
    public GameObject assaultRifleOutline;
    public GameObject medKit;
    public GameObject medKitOutline;
    public GameObject superMedKit;
    public GameObject superMedKitOutline;

    // Start is called before the first frame update
    void Start()
    {
        pistol.SetActive(true);
        pistolOutline.SetActive(true);
        shotgun.SetActive(false);
        shotgunOutline.SetActive(false);
        assaultRifle.SetActive(false);
        assaultRifleOutline.SetActive(false);
        medKit.SetActive(false);
        medKitOutline.SetActive(false);
        superMedKit.SetActive(false);
        superMedKitOutline.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GunCollect();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Slot1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (GunSwitcher.enableShotgun == true)
            {
                Slot2();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (GunSwitcher.enableAssaultRifle == true)
            {
                Slot3();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (GunSwitcher.enableMedKit == true)
            {
                Slot4();    
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
            if (GunSwitcher.enableSuperMedKit == true)
            {
                Slot5();
            }
        if (GunSwitcher.enableMedKit == false)
        {
            pistolOutline.SetActive(true);
            medKit.SetActive(false);
            medKitOutline.SetActive(false);
        }
        if (GunSwitcher.enableSuperMedKit == false)
        {
            pistolOutline.SetActive(true);
            superMedKit.SetActive(false);
            superMedKitOutline.SetActive(false);
        }
    }

    public void Slot1()
    {
        pistolOutline.SetActive(true);
        shotgunOutline.SetActive(false);
        assaultRifleOutline.SetActive(false);
        medKitOutline.SetActive(false);
        superMedKitOutline.SetActive(false);
    }

    public void Slot2()
    {
        pistolOutline.SetActive(false);
        shotgunOutline.SetActive(true);
        assaultRifleOutline.SetActive(false);
        medKitOutline.SetActive(false);
        superMedKitOutline.SetActive(false);
    }

    public void Slot3()
    {
        pistolOutline.SetActive(false);
        shotgunOutline.SetActive(false);
        assaultRifleOutline.SetActive(true);
        medKitOutline.SetActive(false);
        superMedKitOutline.SetActive(false);
    }

    public void Slot4()
    {
        pistolOutline.SetActive(false);
        shotgunOutline.SetActive(false);
        assaultRifleOutline.SetActive(false);
        medKitOutline.SetActive(true);
        superMedKitOutline.SetActive(false);
    }
    
    public void Slot5()
    {
        pistolOutline.SetActive(false);
        shotgunOutline.SetActive(false);
        assaultRifleOutline.SetActive(false);
        medKitOutline.SetActive(false);
        superMedKitOutline.SetActive(true);
    }

    public void GunCollect()
    {
        pistol.SetActive(true);
        if (GunSwitcher.enableShotgun == true)
        {
            shotgun.SetActive(true);
        }
        if (GunSwitcher.enableAssaultRifle == true)
        {
            assaultRifle.SetActive(true);
        }
        if (GunSwitcher.enableMedKit == true)
        {
            medKit.SetActive(true);
        }
        if (GunSwitcher.enableSuperMedKit == true)
        {
            superMedKit.SetActive(true);
        }
    }
}

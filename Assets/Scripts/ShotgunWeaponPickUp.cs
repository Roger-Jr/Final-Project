using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunWeaponPickUp : MonoBehaviour
{
    public GameObject Shotgun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            gameObject.SetActive(false);
            GunSwitcher.enableShotgun = true;
        }
    }

    public void rotation()
    {
        Shotgun.GetComponent<Animator>().Play("ShotgunWeaponPickUpRotation");
    }
}

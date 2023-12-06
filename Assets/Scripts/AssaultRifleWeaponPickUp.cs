using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifleWeaponPickUp : MonoBehaviour
{
    public GameObject assaultRifle;

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
            GunSwitcher.enableAssaultRifle = true;
        }
    }

    public void rotation()
    {
        assaultRifle.GetComponent<Animator>().Play("AssaultRifleWeaponPickUpRotation");
    }
}

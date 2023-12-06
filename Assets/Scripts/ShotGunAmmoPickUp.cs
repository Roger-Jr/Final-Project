using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunAmmoPickUp : MonoBehaviour
{
    public GameObject shotgunAmmoPickUp;

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
            Shotgun.ammoTotal += 6;
        }
    }
    public void rotation()
    {
        shotgunAmmoPickUp.GetComponent<Animator>().Play("ShotgunAmmoPickUpRotation");
    }
}

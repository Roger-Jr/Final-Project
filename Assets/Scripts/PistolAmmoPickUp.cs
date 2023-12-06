using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPickUp : MonoBehaviour
{
    public GameObject pistolAmmoPickUp;

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
            Pistol.ammoTotal += 15;
        }
    }

    public void rotation()
    {
        pistolAmmoPickUp.GetComponent<Animator>().Play("PistolAmmoPickUpRotation");
    }
}

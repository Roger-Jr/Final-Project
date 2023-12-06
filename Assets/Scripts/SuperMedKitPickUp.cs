using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMedKitPickUp : MonoBehaviour
{
    public GameObject superMedKitPickUp;

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
            GunSwitcher.enableSuperMedKit = true;
        }
    }
    public void rotation()
    {
        superMedKitPickUp.GetComponent<Animator>().Play("SuperMedKitPickUpRotation");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKitPickUp : MonoBehaviour
{
    public GameObject medKitPickUp;

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
            GunSwitcher.enableMedKit = true;
        }
    }
    public void rotation()
    {
        medKitPickUp.GetComponent<Animator>().Play("MedKitPickUpRotation");
    }
}

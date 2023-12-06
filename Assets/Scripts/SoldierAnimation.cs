using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimation : MonoBehaviour
{
    public GameObject soldier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soldier.GetComponent<Animator>().Play("demo_combat_idle");
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public Transform targetObj;
    public float moveSpeed;
    public bool inRange = false;
    public GameObject player;
    public GameObject enemy;
    public GameObject attackSound;
    public GameObject screamSound;
    private bool timerOn = true;
    public float timer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        attackSound.SetActive(false);
        screamSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        death();
    }
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
       {
           ZombieHealth.health -= 1;
       }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            inRange = false;
            timerOn = true;
        }
    }
    public void movement()
    {
        if (inRange == true)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, moveSpeed * Time.deltaTime);
            transform.LookAt(player.transform);
            enemy.GetComponent<Animator>().Play("Z_Run_InPlace");
            attackSound.SetActive(true);
            screamSound.SetActive(true);
            timerOn = false;
        }
        if (inRange == false)
        {
            enemy.GetComponent<Animator>().Play("Z_Idle");
            if (timerOn == true)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    attackSound.SetActive(false);
                    screamSound.SetActive(false);
                    timer = 0.5f;
                    timerOn = false;
                }
        
            }
        }
    }
    public void death()
    {
        if (ZombieHealth.health == 0)
        {
            gameObject.SetActive(false);
        }
        if (ZombieHealth.health == 1)
        {
            attackSound.SetActive(false);
            screamSound.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform targetObj;
    public float moveSpeed;
    private bool inRange = false;
    public GameObject player;
    public GameObject enemy;
    public GameObject attackSound;
    public GameObject screamSound;
    public GameObject enemyObj;
    private bool timerOn = true;
    public float timer = 0.5f;
    public GameObject playerObj, zombie, healthBar0, healthBar1, healthBar2, healthBar3, healthBar4, healthBar5;
    public Transform healthBar;
    public GameObject healthBarOn;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        healthBarOn.SetActive(false);
        attackSound.SetActive(false);
        screamSound.SetActive(false);
        health = 6;
        healthBar0.gameObject.SetActive(true);
        healthBar1.gameObject.SetActive(true);
        healthBar2.gameObject.SetActive(true);
        healthBar3.gameObject.SetActive(true);
        healthBar4.gameObject.SetActive(true);
        healthBar5.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void Update() 
    {
        Movement();
        Death();
        {
            healthBar.LookAt(player.transform);
            switch (health)
            {
                case 6:
                    health = 6;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(true);
                    healthBar2.gameObject.SetActive(true);
                    healthBar3.gameObject.SetActive(true);
                    healthBar4.gameObject.SetActive(true);
                    healthBar5.gameObject.SetActive(true);
                    break;
                case 5:
                    health = 5;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(true);
                    healthBar2.gameObject.SetActive(true);
                    healthBar3.gameObject.SetActive(true);
                    healthBar4.gameObject.SetActive(true);
                    healthBar5.gameObject.SetActive(false);
                    break;
                case 4:
                    health = 4;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(true);
                    healthBar2.gameObject.SetActive(true);
                    healthBar3.gameObject.SetActive(true);
                    healthBar4.gameObject.SetActive(false);
                    healthBar5.gameObject.SetActive(false);
                    break;
                case 3:
                    health = 3;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(true);
                    healthBar2.gameObject.SetActive(true);
                    healthBar3.gameObject.SetActive(false);
                    healthBar4.gameObject.SetActive(false);
                    healthBar5.gameObject.SetActive(false);
                    break;
                case 2:
                    health = 2;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(true);
                    healthBar2.gameObject.SetActive(false);
                    healthBar3.gameObject.SetActive(false);
                    healthBar4.gameObject.SetActive(false);
                    healthBar5.gameObject.SetActive(false);
                    break;
                case 1:
                    health = 1;
                    healthBar0.gameObject.SetActive(true);
                    healthBar1.gameObject.SetActive(false);
                    healthBar2.gameObject.SetActive(false);
                    healthBar3.gameObject.SetActive(false);
                    healthBar4.gameObject.SetActive(false);
                    healthBar5.gameObject.SetActive(false);
                    break;
                case 0:
                    health = 0;
                    healthBar0.gameObject.SetActive(false);
                    healthBar1.gameObject.SetActive(false);
                    healthBar2.gameObject.SetActive(false);
                    healthBar3.gameObject.SetActive(false);
                    healthBar4.gameObject.SetActive(false);
                    healthBar5.gameObject.SetActive(false);
                    zombie.SetActive(false);
                    attackSound.SetActive(false);
                    screamSound.SetActive(false);
                    break;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("PistolBullet"))
        {
            health -= 1;
            healthBarOn.SetActive(true);
            inRange = true;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("ShotgunBullet"))
        {
            health -= 3;
            healthBarOn.SetActive(true);
            inRange = true;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("AssaultRifleBullet"))
        {
            health -= 2;
            healthBarOn.SetActive(true);
            inRange = true;
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
    public void Movement()
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
    public void Death()
    {
        if (health == 0)
        {
            enemyObj.SetActive(false);
        }
    }
}

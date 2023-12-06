using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssaultRifle : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public TMP_Text reloadValueText;
    public GameObject reloadText;
    public TMP_Text amountText;
    public GameObject ammoText;
    public GameObject gun;
    public float bulletSpeed = 10f;
    public float reloadValue = 4f;
    private bool reloading;
    public float bulletsLeft = 30f;
    private bool shooting = true;
    public float bulletCooldown = 0.5f;
    private bool bulletCooldownOn = false;
    public GameObject AudioClip;
    public GameObject AudioReload;
    public static float ammoTotal = 0;
    public TMP_Text ammoTotalText;
    public static bool weaponUse = false;

    private void Start()
    {
        AudioClip.SetActive(false);
        AudioReload.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
       shoots();
       reload();
       aim();
       ammoPickUp();
    }
    public void shoots()
    {
        if (shooting == true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (bulletsLeft >= 1)
                {
                    PauseGame.gameIsPaused = false;
                    AudioClip.SetActive(true);
                    Debug.Log(bulletCooldown);
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                    bulletsLeft -= 1;
                    Debug.Log(bulletsLeft);
                    amountText.text = bulletsLeft.ToString("0");
                    bulletCooldownOn = true;
                }
                if (bulletsLeft <= 0)
                {
                    bulletsLeft = 0;
                    shooting = false;
                }
            }
            
        }
        if (bulletCooldownOn == true)
        {
            shooting = false;
            bulletCooldown -= Time.deltaTime;
            Debug.Log(bulletCooldown);
            if (bulletCooldown <= 0)
            {
                bulletCooldownOn = false;
                AudioClip.SetActive(false);
                shooting = true;
                bulletCooldown = 0.5f;
            }
            if (bulletsLeft == 0)
            {
                shooting = false;
            }
        }
    }
    public void reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            reloading = true;
            shooting = false;
            if ((bulletsLeft == 30) && (ammoTotal >= 0))
            {
                ammoTotal -= 0;
                bulletsLeft += 0;
            }
            if ((bulletsLeft == 29) && (ammoTotal >= 1))
            {
                ammoTotal -= 1;
                bulletsLeft += 1;
            }
            if ((bulletsLeft == 29) && (ammoTotal < 1))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 28) && (ammoTotal >= 2))
            {
                ammoTotal -= 2;
                bulletsLeft += 2;
            }
            if ((bulletsLeft == 28) && (ammoTotal < 2))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 27) && (ammoTotal >= 3))
            {
                ammoTotal -= 3;
                bulletsLeft += 3;
            }
            if ((bulletsLeft == 27) && (ammoTotal < 3))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 26) && (ammoTotal >= 4))
            {
                ammoTotal -= 4;
                bulletsLeft += 4;
            }
            if ((bulletsLeft == 26) && (ammoTotal < 4))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 25) && (ammoTotal >= 5))
            {
                ammoTotal -= 5;
                bulletsLeft += 5;
            }
            if ((bulletsLeft == 25) && (ammoTotal < 5))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 24) && (ammoTotal >= 6))
            {
                ammoTotal -= 6;
                bulletsLeft += 6;
            }
            if ((bulletsLeft == 24) && (ammoTotal < 6))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 23) && (ammoTotal >= 7))
            {
                ammoTotal -= 7;
                bulletsLeft += 7;
            }
            if ((bulletsLeft == 23) && (ammoTotal < 7))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 22) && (ammoTotal >= 8))
            {
                ammoTotal -= 8;
                bulletsLeft += 8;
            }
            if ((bulletsLeft == 22) && (ammoTotal < 8))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 21) && (ammoTotal >= 9))
            {
                ammoTotal -= 9;
                bulletsLeft += 9;
            }
            if ((bulletsLeft == 21) && (ammoTotal < 9))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 20) && (ammoTotal >= 10))
            {
                ammoTotal -= 10;
                bulletsLeft += 10;
            }
            if ((bulletsLeft == 20) && (ammoTotal < 10))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 19) && (ammoTotal >= 11))
            {
                ammoTotal -= 11;
                bulletsLeft += 11;
            }
            if ((bulletsLeft == 19) && (ammoTotal < 11))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 18) && (ammoTotal >= 12))
            {
                ammoTotal -= 12;
                bulletsLeft += 12;
            }
            if ((bulletsLeft == 18) && (ammoTotal < 12))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 17) && (ammoTotal >= 13))
            {
                ammoTotal -= 13;
                bulletsLeft += 13;
            }
            if ((bulletsLeft == 17) && (ammoTotal < 13))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 16) && (ammoTotal >= 14))
            {
                ammoTotal -= 14;
                bulletsLeft += 14;
            }
            if ((bulletsLeft == 16) && (ammoTotal < 14))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 15) && (ammoTotal >= 15))
            {
                ammoTotal -= 15;
                bulletsLeft += 15;
            }
            if ((bulletsLeft == 15) && (ammoTotal < 15))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 14) && (ammoTotal >= 16))
            {
                ammoTotal -= 16;
                bulletsLeft += 16;
            }
            if ((bulletsLeft == 14) && (ammoTotal < 16))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 13) && (ammoTotal >= 17))
            {
                ammoTotal -= 17;
                bulletsLeft += 17;
            }
            if ((bulletsLeft == 13) && (ammoTotal < 17))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 12) && (ammoTotal >= 18))
            {
                ammoTotal -= 18;
                bulletsLeft += 18;
            }
            if ((bulletsLeft == 12) && (ammoTotal < 18))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 11) && (ammoTotal >= 19))
            {
                ammoTotal -= 19;
                bulletsLeft += 19;
            }
            if ((bulletsLeft == 11) && (ammoTotal < 19))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 10) && (ammoTotal >= 20))
            {
                ammoTotal -= 20;
                bulletsLeft += 20;
            }
            if ((bulletsLeft == 10) && (ammoTotal < 20))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 9) && (ammoTotal >= 21))
            {
                ammoTotal -= 21;
                bulletsLeft += 21;
            }
            if ((bulletsLeft == 9) && (ammoTotal < 21))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 8) && (ammoTotal >= 22))
            {
                ammoTotal -= 22;
                bulletsLeft += 22;
            }
            if ((bulletsLeft == 8) && (ammoTotal < 22))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 7) && (ammoTotal >= 23))
            {
                ammoTotal -= 23;
                bulletsLeft += 23;
            }
            if ((bulletsLeft == 7) && (ammoTotal < 23))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 6) && (ammoTotal >= 24))
            {
                ammoTotal -= 24;
                bulletsLeft += 24;
            }
            if ((bulletsLeft == 6) && (ammoTotal < 24))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 5) && (ammoTotal >= 25))
            {
                ammoTotal -= 25;
                bulletsLeft += 25;
            }
            if ((bulletsLeft == 5) && (ammoTotal < 25))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 4) && (ammoTotal >= 26))
            {
                ammoTotal -= 26;
                bulletsLeft += 26;
            }
            if ((bulletsLeft == 4) && (ammoTotal < 26))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 3) && (ammoTotal >= 27))
            {
                ammoTotal -= 27;
                bulletsLeft += 27;
            }
            if ((bulletsLeft == 3) && (ammoTotal < 27))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 2) && (ammoTotal >= 28))
            {
                ammoTotal -= 28;
                bulletsLeft += 28;
            }
            if ((bulletsLeft == 2) && (ammoTotal < 28))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 1) && (ammoTotal >= 29))
            {
                ammoTotal -= 29;
                bulletsLeft += 29;
            }
            if ((bulletsLeft == 1) && (ammoTotal < 29))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 0) && (ammoTotal >= 30))
            {
                ammoTotal -= 30;
                bulletsLeft += 30;
            }
            if ((bulletsLeft == 0) && (ammoTotal < 30))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
        }
        if (reloading)
        {
            AudioReload.SetActive(true);
            reloadText.SetActive(true);
            reloadValue -= Time.deltaTime;
            Debug.Log(reloadValue);
            reloadValueText.text = reloadValue.ToString("0");
            if (reloadValue <= 0)
            {
                AudioReload.SetActive(false);
                reloadText.SetActive(false);
                reloadValue = 4;
                Debug.Log(bulletsLeft);
                shooting = true;
                reloading = false;
                amountText.text = bulletsLeft.ToString("0");
            }
        }
    }
    public void aim()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gun.GetComponent<Animator>().Play("AssaultRifleAnimation");
        }
        if (Input.GetMouseButtonUp(1))
        {
            gun.GetComponent<Animator>().Play("New State");
        }
    }
    public void ammoPickUp()
    {
        ammoTotalText.text = ammoTotal.ToString("0");
    }
}

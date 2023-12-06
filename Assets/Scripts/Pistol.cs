using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pistol : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public TMP_Text reloadValueText;
    public GameObject reloadText;
    public TMP_Text amountText;
    public GameObject ammoText;
    public GameObject gun;
    public float bulletSpeed = 10f;
    public float reloadValue = 3f;
    private bool reloading; 
    public float bulletsLeft = 15f;
    private bool shooting = true;
    public float ClipLength = 1f;
    public GameObject AudioClip;
    public float bulletCooldown = 0.5f;
    private bool bulletCooldownOn = false;
    public GameObject AudioReload;
    public static float ammoTotal = 0;
    public TMP_Text ammoTotalText;

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
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (bulletsLeft >= 1)
                {
                    AudioClip.SetActive(true);
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                    bulletsLeft -= 1;
                    Debug.Log(bulletsLeft);
                    amountText.text = bulletsLeft.ToString("0");
                    bulletCooldownOn = true;
                }
                if (bulletsLeft <= 0)
                {
                    shooting = false;
                    bulletsLeft = 0;
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
                bulletCooldown = 0.9f;
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
            if ((bulletsLeft == 15) && (ammoTotal >= 0))
            {
                ammoTotal -= 0;
                bulletsLeft += 0;
            }
            if ((bulletsLeft == 14) && (ammoTotal >= 1))
            {
                ammoTotal -= 1;
                bulletsLeft += 1;
            }
            if ((bulletsLeft == 14) && (ammoTotal < 1))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 13) && (ammoTotal >= 2))
            {
                ammoTotal -= 2;
                bulletsLeft += 2;
            }
            if ((bulletsLeft == 13) && (ammoTotal < 2))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 12) && (ammoTotal >= 3))
            {
                ammoTotal -= 3;
                bulletsLeft += 3;
            }
            if ((bulletsLeft == 12) && (ammoTotal < 3))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 11) && (ammoTotal >= 4))
            {
                ammoTotal -= 4;
                bulletsLeft += 4;
            }
            if ((bulletsLeft == 11) && (ammoTotal < 4))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 10) && (ammoTotal >= 5))
            {
                ammoTotal -= 5;
                bulletsLeft += 5;
            }
            if ((bulletsLeft == 10) && (ammoTotal < 5))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 9) && (ammoTotal >= 6))
            {
                ammoTotal -= 6;
                bulletsLeft += 6;
            }
            if ((bulletsLeft == 9) && (ammoTotal < 6))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 8) && (ammoTotal >= 7))
            {
                ammoTotal -= 7;
                bulletsLeft += 7;
            }
            if ((bulletsLeft == 8) && (ammoTotal < 7))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 7) && (ammoTotal >= 8))
            {
                ammoTotal -= 8;
                bulletsLeft += 8;
            }
            if ((bulletsLeft == 7) && (ammoTotal < 8))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 6) && (ammoTotal >= 9))
            {
                ammoTotal -= 9;
                bulletsLeft += 9;
            }
            if ((bulletsLeft == 6) && (ammoTotal < 9))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 5) && (ammoTotal >= 10))
            {
                ammoTotal -= 10;
                bulletsLeft += 10;
            }
            if ((bulletsLeft == 5) && (ammoTotal < 10))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 4) && (ammoTotal >= 11))
            {
                ammoTotal -= 11;
                bulletsLeft += 11;
            }
            if ((bulletsLeft == 4) && (ammoTotal < 11))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 3) && (ammoTotal >= 12))
            {
                ammoTotal -= 12;
                bulletsLeft += 12;
            }
            if ((bulletsLeft == 3) && (ammoTotal < 12))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 2) && (ammoTotal >= 13))
            {
                ammoTotal -= 13;
                bulletsLeft += 13;
            }
            if ((bulletsLeft == 2) && (ammoTotal < 13))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 1) && (ammoTotal >= 14))
            {
                ammoTotal -= 14;
                bulletsLeft += 14;
            }
            if ((bulletsLeft == 1) && (ammoTotal < 14))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 0) && (ammoTotal >= 15))
            {
                ammoTotal -= 15;
                bulletsLeft += 15;
            }
            if ((bulletsLeft == 0) && (ammoTotal < 15))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
        }
        if (reloading)
        {
            shooting = false;
            reloadText.SetActive(true);
            AudioReload.SetActive(true);
            reloadValue -= Time.deltaTime;
            Debug.Log(reloadValue);
            reloadValueText.text = reloadValue.ToString("0");
            if (reloadValue <= 0)
            {
                reloadText.SetActive(false);
                AudioReload.SetActive(false);
                reloadValue = 3;
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
            gun.GetComponent<Animator>().Play("PistolAnimation");
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

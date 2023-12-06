using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public TMP_Text reloadValueText;
    public GameObject reloadText;
    public TMP_Text amountText;
    public GameObject ammoText;
    public GameObject gun;
    public float bulletSpeed = 10f;
    public float reloadValue = 6f;
    private bool reloading;
    public float bulletsLeft = 6f;
    private bool shooting = true;
    public GameObject AudioClip;
    public GameObject AudioReload;
    public float bulletCooldown = 1f;
    private bool bulletCooldownOn = false;
    private bool bulletReloadPerShotOn = false;
    public float bulletReloadPerShotNumber = 0.8f;
    public float bulletReloadPerShotDone = 0.1f;
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
                bulletCooldown = 1f;
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
            bulletReloadPerShotOn = true;
            if ((bulletsLeft == 6) && (ammoTotal >= 0))
            {
                ammoTotal -= 0;
                bulletsLeft += 0;
            }
            if ((bulletsLeft == 5) && (ammoTotal >= 1))
            {
                ammoTotal -= 1;
                bulletsLeft += 1;
            }
            if ((bulletsLeft == 5) && (ammoTotal < 1))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 4) && (ammoTotal >= 2))
            {
                ammoTotal -= 2;
                bulletsLeft += 2;
            }
            if ((bulletsLeft == 4) && (ammoTotal < 2))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 3) && (ammoTotal >= 3))
            {
                ammoTotal -= 3;
                bulletsLeft += 3;
            }
            if ((bulletsLeft == 3) && (ammoTotal < 3))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 2) && (ammoTotal >= 4))
            {
                ammoTotal -= 4;
                bulletsLeft += 4;
            }
            if ((bulletsLeft == 2) && (ammoTotal < 4))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 1) && (ammoTotal >= 5))
            {
                ammoTotal -= 5;
                bulletsLeft += 5;
            }
            if ((bulletsLeft == 1) && (ammoTotal < 5))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
            if ((bulletsLeft == 0) && (ammoTotal >= 6))
            {
                ammoTotal -= 6;
                bulletsLeft += 6;
            }
            if ((bulletsLeft == 0) && (ammoTotal < 6))
            {
                bulletsLeft += ammoTotal;
                ammoTotal -= ammoTotal;
            }
        }
        if (reloading)
        {
            reloadText.SetActive(true);
            reloadValue -= Time.deltaTime;
            Debug.Log(reloadValue);
            reloadValueText.text = reloadValue.ToString("0");
            if (reloadValue <= 0)
            {
                AudioReload.SetActive(false);
                reloadText.SetActive(false);
                reloadValue = 6;
                Debug.Log(bulletsLeft);
                shooting = true;
                reloading = false;
                bulletReloadPerShotOn = false;
                amountText.text = bulletsLeft.ToString("0");
            }
        }
        if (bulletReloadPerShotOn == true)
        {
            bulletReloadPerShotNumber -= Time.deltaTime;
            if (bulletReloadPerShotNumber <= 0)
            {
                AudioReload.SetActive(true);
                bulletReloadPerShotDone -= Time.deltaTime;
                if (bulletReloadPerShotDone <= 0)
                {
                    AudioReload.SetActive(false);
                    bulletReloadPerShotNumber = 0.8f;
                    bulletReloadPerShotDone = 0.1f;
                }
            }
            
        }
    }
    public void aim()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gun.GetComponent<Animator>().Play("ShotGunAnimation");
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

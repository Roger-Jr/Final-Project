using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
        GunSwitcher.enableAssaultRifle = false;
        GunSwitcher.enableShotgun = false;
        GunSwitcher.enableMedKit = false;
        GunSwitcher.enableSuperMedKit = false;
    }
}

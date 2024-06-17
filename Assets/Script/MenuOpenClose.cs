using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpenClose : MonoBehaviour
{
    public GameObject openMenu;


    public void OpenMenu()
    {
        openMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseMenu()
    {
        openMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}

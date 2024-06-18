using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private float baseAtkPower;
    public TextMeshProUGUI text;
    private int playerGold;
    public TextMeshProUGUI upgradegold;

    private void Awake()
    {
        
    }

    private void Start()
    {
        StartCoroutine(AutoTouch());
        upgradegold.text = (baseAtkPower * 2).ToString();
    }

    private void Update()
    {
        if (Time.timeScale != 0f) {
            if (Input.GetMouseButtonDown(0))
            {
                ReloadScreen();
            }
        }
    }

    private void ReloadScreen()
    {
        text.text = ((int.Parse(text.text) + 1) + baseAtkPower).ToString();
        playerGold = int.Parse(text.text);
        GameManager.Instance._enemy.enemyHpControl.HpCheck(baseAtkPower);
    }

    public void UpgradeAtk()
    {
        if (playerGold >= baseAtkPower * 2)
        {
            playerGold -= (int)baseAtkPower * 2;
            text.text = playerGold.ToString();
            baseAtkPower++;
            upgradegold.text = (baseAtkPower * 2).ToString();
        }
        else
        {
            Debug.Log("골드가 부족합니다!");
        }
    }

    IEnumerator AutoTouch()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            ReloadScreen();
        }
    }
    

    
}

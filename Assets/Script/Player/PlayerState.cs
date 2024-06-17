using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private float baseAtkPower;
    public TextMeshProUGUI text;
    private int playerGold;

    private void Awake()
    {
        
    }

    private void Start()
    {
        StartCoroutine(AutoTouch());
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
    }

    public float GetBaseAtkPower()
    {
        return baseAtkPower;
    }

    public void UpgradeAtk()
    {
        if (playerGold >= baseAtkPower * 2)
        {
            playerGold -= (int)baseAtkPower * 2;
            text.text = playerGold.ToString();
            baseAtkPower++;
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

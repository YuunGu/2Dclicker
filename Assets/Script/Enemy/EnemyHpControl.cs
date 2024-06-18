using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpControl : MonoBehaviour
{
    public Image enemyHpBar;
    [SerializeField] private int enemyHpLevel;
    [SerializeField] private float enemyHp;
    [SerializeField] private float maxEnemyHp;

    private void Start()
    {
        enemyHpLevel = 1;
        enemyHp = enemyHpLevel * 10;
        maxEnemyHp = enemyHp;
    }
    private void Update()
    {
        enemyHpBar.fillAmount = enemyHp/maxEnemyHp;
    }
    public void HpCheck(float damage)
    {
       enemyHp -= damage;
       if(enemyHp <= 0)
        {
            enemyHp = 0;
            OnDeath();
        }
    }

    private void OnDeath()
    {        
        Debug.Log("ÀûÃ³Ä¡!");
        this.gameObject.SetActive(false);
        HpLevelUp();
    }

    private void HpLevelUp()
    {
        enemyHpLevel++;
        enemyHp = enemyHpLevel * 10;
        maxEnemyHp = enemyHp;
        this.gameObject.SetActive(true);
    }
}

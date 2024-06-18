using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public EnemyHpControl enemyHpControl;
    private void Awake()
    {
        enemyHpControl = GetComponent<EnemyHpControl>();
        GameManager.Instance._enemy = this;
    }
}

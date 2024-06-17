using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    public PlayerManager _player;
    public PlayerManager Player
    {
        get { return _player; }
        set { _player = value; }
    }

    public EnemyManager _enemy;
    public EnemyManager Enemy
    {
        get { return _enemy; }
        set { _enemy = value; }
    }

    public UIManager _ui;
    public UIManager UI
    {
        get { return _ui; }
        set { _ui = value; }
    }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance == this)
            {
                Destroy(gameObject);
            }
        }
    }
}

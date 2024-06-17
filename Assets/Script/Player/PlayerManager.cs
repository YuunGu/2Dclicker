using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerState playerState;

    private void Awake()
    {
        playerState = GetComponent<PlayerState>();
        GameManager.Instance._player = this;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    public Player player;

    void Start()
    {
        player.DecreaseHp(10);
    }

    void Update()
    {
        Debug.Log(player.hp);
    }
}

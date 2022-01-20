using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    GameObject Player;
    GameObject Enemy;
    public float Speed;

    
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("player");
        Enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(Player.transform.position.x, Player.transform.position.y), Speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    GameObject Player;
    GameObject Enemy;
    public float Speed;

    private Rigidbody2D rbody2D;

    private float jumpForce = 350f;

    private int jumpCount = 0;

    private bool countflg;//カウント中敵を動かなくする(変更点)


    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("player");
        Enemy = GameObject.Find("Enemy");
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        countflg = CoundDown.countflg;//変更点

        if (countflg == false)//変更点
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(Player.transform.position.x, Player.transform.position.y), Speed * Time.deltaTime);
        }
        //if (Input.GetMouseButtonDown(0) && this.jumpCount < 1)
        //{
        //    this.rbody2D.AddForce(transform.up * jumpForce);
        //    jumpCount++;
        //}

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}
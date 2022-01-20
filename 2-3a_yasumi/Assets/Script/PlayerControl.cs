using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator anim = null;

    private Rigidbody2D rb2d;
    private float x_val;
    private float speed;
    public float inputSpeed;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        x_val = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        //待機
        if (x_val == 0)
        {
            speed = 0;
            anim.SetBool("right_run", false);
            anim.SetBool("left_run", false);
        }
        //右に移動
        else if (x_val > 0)
        {
            speed = inputSpeed;
            anim.SetBool("right_run",true);
        }
        //左に移動
        else if (x_val < 0)
        {
            speed = inputSpeed * -1;
            anim.SetBool("left_run", true);
        }
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }
}
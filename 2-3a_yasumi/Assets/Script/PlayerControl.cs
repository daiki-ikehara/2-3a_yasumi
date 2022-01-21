using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator anim = null;

    private Rigidbody2D rb2d;//Rigidbody2dの変数
    private float x_val;//X座標
    private float speed;//x座標のキャラのスピード
    private bool jumpflg = false;
    private float height;
    private float jumpPos = 0.0f;
    private bool setti;
    public float inputSpeed;
    public float JumpPower;
    public float gravity;
    public float jumpheight;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        setti = GameObject.FindGameObjectWithTag("floar");
    }

    void Update()
    {
        //height = 0;
        x_val = Input.GetAxis("Horizontal");

        //ジャンプ押したときの処理

        if (Input.GetButtonDown("Jump"))//ジャンプ押すと
        {
            rb2d.AddForce(transform.up*JumpPower,ForceMode2D.Impulse);

            //jumpPos = transform.position.y;//ジャンプする前の座標を渡す
            //height += JumpPower;//座標にジャンプの値を渡してジャンプ
            jumpflg = true;//ジャンプフラグをture

        }
        else//ジャンプボタンが押されていないとき
        {
            height -= gravity;//重力
            jumpflg = false;//じゃんぷふらごをおふ

        }

        //if (jumpflg && jumpPos + jumpheight > transform.position.y)//ジャンプボタンが押されてるかつジャンプの範囲制御
        //{
        //    height += JumpPower;//ジャンプさせる
        //    jumpflg = true;//ジャンプフラグ
        //}
        //else//ジャンプボタンが押されていないとき
        //{
        //    jumpflg = false;//ジャンプフラグオフ
        //}

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
            anim.SetBool("right_run", true);
            //rb2d.AddForce(transform.right * inputSpeed, ForceMode2D.Force);
            transform.position = new Vector2(transform.position.x + inputSpeed,transform.position.y);
        }
        //左に移動
        else if (x_val < 0)
        {
            speed = inputSpeed * -1;
            anim.SetBool("left_run", true);
            transform.position = new Vector2(transform.position.x - inputSpeed, transform.position.y);
            //rb2d.AddForce(transform.right * -inputSpeed, ForceMode2D.Force);
        }
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード)
        //rb2d.velocity = new Vector2(speed, 0);
    }
}
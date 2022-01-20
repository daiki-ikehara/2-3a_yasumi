using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator anim = null;

    private Rigidbody2D rb2d;//Rigidbody2dの変数
    private float x_val;//X座標
    private float speed;//x座標のキャラのスピード
    private float jump=0;//ジャンプボタンが押されているかどうか
    private bool jumpflg = false;
    private float height;
    private float jumpPos = 0.0f;
    public float inputSpeed;
    public float JumpPower;
    public float gravity;
    public float jumpheight;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        Debug.LogFormat("%d",jump);
        height = this.transform.position.y;
        x_val = Input.GetAxis("Horizontal");
        height = -gravity;

        //ジャンプ押したときの処理

        if (Input.GetButtonDown("Jump"))//ジャンプ押すと
        {
            jumpPos = transform.position.y;//ジャンプする前の座標を渡す
            height = JumpPower;//座標にジャンプの値を渡してジャンプ
            jumpflg = true;//ジャンプフラグをture
            jump = 1;//ジャンプボタンを押したかどうか
            Debug.Log("jump");

        }
        else//ジャンプボタンが押されていないとき
        {
            jumpflg = false;//じゃんぷふらごをおふ
            jump = 0;//ジャンプボタンを押してるかをオフ
        }

        if (jump > 0&&jumpPos+jumpheight>transform.position.y)//ジャンプボタンが押されてるかつジャンプの範囲制御
        {
            height +=JumpPower;//ジャンプさせる
            jumpflg = true;//ジャンプフラグ
        }
        else//ジャンプボタンが押されていないとき
        {
            jumpflg = false;//ジャンプフラグオフ
            jump = 0;//ジャンプボタン押されているかをオフ
        }

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
        }
        //左に移動
        else if (x_val < 0)
        {
            speed = inputSpeed * -1;
            anim.SetBool("left_run", true);
        }
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード)
        rb2d.velocity = new Vector2(speed, height);
    }
}
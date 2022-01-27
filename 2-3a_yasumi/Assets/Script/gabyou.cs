using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gabyou : MonoBehaviour
{
    [SerializeField]
    private int damagePoint = 10;
    private bool isDamaged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isDamaged && collision.tag == "Player")
        {
            var playerScript = collision.GetComponent<HPScript>();
            playerScript.SetHp(playerScript.GetHp() - damagePoint);
            isDamaged = true;
            Debug.Log(damagePoint+"ダメージを受けた");
            //gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    [SerializeField]
    private int recoveryPoint = 40;
    private bool isRecovered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isRecovered && collision.tag == "Player")
        {
            var playerScript = collision.GetComponent<HPScript>();
            playerScript.SetHp(playerScript.GetHp() + recoveryPoint);
            isRecovered = true;
            Debug.Log(recoveryPoint + "回復した");
        }
    }
}
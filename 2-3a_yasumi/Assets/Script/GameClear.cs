using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject clearPanel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))//プレイヤーに当たった時に
        {
            clearPanel.SetActive(true);
            Time.timeScale = 0f;  
        }
    }
}

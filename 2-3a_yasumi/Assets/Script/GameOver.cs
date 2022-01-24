using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject overPanel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))//エネミーに当たった時に
        {
            overPanel.SetActive(true);
            Debug.Log("当たった");
            Time.timeScale = 0f;
        }
    }
}

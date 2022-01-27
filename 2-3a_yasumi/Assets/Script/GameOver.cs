using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject overPanel;
    public Button FirstSelectButton;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))//エネミーに当たった時に
        {
            overPanel.SetActive(true);
            Debug.Log("当たった");
            
            FirstSelectButton.Select();
        }
    }
}

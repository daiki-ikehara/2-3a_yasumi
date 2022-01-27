using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject overPanel;
    public Button FirstSelectButton;

    public static bool gameoverflg=false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))//エネミーに当たった時に
        {
            gameoverflg = true;
            Time.timeScale = 0f;
            overPanel.SetActive(true);
            
            FirstSelectButton.Select();
        }
    }
}

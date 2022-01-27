using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoundDown : MonoBehaviour
{

    public AudioClip CountSound;
    AudioSource audioSource;

    public Text CountText;

    float countdown = 4f;
    int count;
    public static bool countflg = true;
    private bool gameoverflg;
    private bool clearflg;
    private bool retryflg;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(retryflg);


        retryflg = GameManager.retryflg;
        gameoverflg = GameOver.gameoverflg;
        clearflg = GameClear.clearflg;


        if (clearflg == true)
        {
            countflg = true;
        }

        if (gameoverflg == true)
        {
            countflg = true;
        }

        if (retryflg == true)
        {
            gameoverflg = false;
        }




        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();

        }
        else if (clearflg == false&& gameoverflg == false)  {
            CountText.text = "";
            countflg = false;
        }
    }
}

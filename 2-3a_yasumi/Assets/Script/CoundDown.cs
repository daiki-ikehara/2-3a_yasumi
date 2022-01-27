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


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
            //if (!countflg)
            //{
            //    audioSource.PlayOneShot(CountSound);
            //}

        }
        else {
            CountText.text = "";
            countflg = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinUI : MonoBehaviour
{

    [SerializeField] Text wonText;
    [SerializeField] Text Score;
    [SerializeField] AudioSource Myaudio;
    [SerializeField] GameObject WonGO;
    void Start()
    {
        WonGO.SetActive(false);
    }

    public void Won(int multiplyer,int num) 
    {


        WonGO.SetActive(true);
        Myaudio.Play();
        wonText.text = "X" + multiplyer.ToString();
        Score.text = "Score: " + num.ToString();
        Time.timeScale = 0;
    }
}

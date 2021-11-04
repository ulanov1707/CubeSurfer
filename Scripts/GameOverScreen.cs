using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScreen : MonoBehaviour
{
    [SerializeField] Text score;
   
    public void SetScore (int num)
    {
        score.text = "Score: " + num.ToString();
    }
}

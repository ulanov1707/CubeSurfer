using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    CollecterCube collecter;
    [SerializeField] GameObject GameOverObj;
    [SerializeField] GameOverScreen GameOverScreenRef;
    void Start()
    {
        collecter = GameObject.Find("CollectorCube").GetComponent<CollecterCube>();
        GameOverObj.SetActive(false);
       
    }

    
    void Update()
    {
        updateScore();
    }
    void updateScore()
    {
        ScoreText.text = collecter.ScoreDimonds.ToString();
    }

    public void GameOver(){

        
        Time.timeScale = 0;
        GameOverObj.SetActive(true);
        GameOverScreenRef.SetScore(collecter.ScoreDimonds);
    }
    
}

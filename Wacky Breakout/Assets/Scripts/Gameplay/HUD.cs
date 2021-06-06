using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public  class HUD : MonoBehaviour
{

   
        public static  Text ScoreText;
    public static Text ballsOnScreen;
    public static Text ballsLeft;
    public static Text highScore;
    public static float score = 0;
    public static float highscore = 0;
   public static int count = 1;
    public static int ballsLeftcount = 10;
   

    // Start is called before the first frame update
    public  void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        ballsOnScreen = GameObject.FindGameObjectWithTag("ballonscreen").GetComponent<Text>();
        ballsLeft = GameObject.FindGameObjectWithTag("ballleft").GetComponent<Text>();
        highScore = GameObject.FindGameObjectWithTag("highscore").GetComponent<Text>();

    }
    public void Update()
    {
        //count =  GameObject.FindGameObjectsWithTag("Ball").Length;
        
        ballsOnScreen.text = "Balls on Screen: " + count;
        ballsLeft.text = "Balls Left: " + ballsLeftcount;
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
        checkGameEnd();
        
        

    }

    // Update is called once per frame


    public static void addScore(float a) 
    {
        score += a;
      ScoreText.text = "Score: "+score;
    
    }
    public void setHS(int hs) 
    {
        PlayerPrefs.SetInt("HighScore", hs);
    }
    public int  getHS()
    {
        int hs = PlayerPrefs.GetInt("HighScore");
        return hs;
    }
    public void checkGameEnd() {
        if (ballsLeftcount == 0) {
            highscore = score;
            int hs = getHS();
            if (highscore > hs) setHS((int)highscore);
           
            
        }
    
    }
}


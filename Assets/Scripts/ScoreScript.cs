using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;  // for using unity UI element
using TMPro; //for using text mesh pro
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    
    public int MyScore = 0;
    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI FinalScoreText;
    
    // Update is called once per frame
    void Update()
    {
        ScoreUI.text = MyScore.ToString();   //MyScore is int data tye while Score UI is string. so we need to chang edata type of score to make them equal and it gets updated every time
        FinalScoreText.text = "Score : " + MyScore.ToString();
    }

    public void AddScore(int score)  //We create an add socre method to update score whenever player collides with red cube and then we will call this method in our player collision script
    {
        MyScore = MyScore + score;
    }
}

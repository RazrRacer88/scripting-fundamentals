using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "George";
    private int Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
   
    void Update()
    {
        
    }

    private void IncreaseScore()
    {
        Score += 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health -= 20;
    }
}

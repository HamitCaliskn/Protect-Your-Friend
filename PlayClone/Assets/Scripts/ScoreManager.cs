using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] int damagane;
    [SerializeField] TextMeshProUGUI ScoreText;

    public int Damagane
    {
        get { return damagane; }set { damagane = value; } 
    }
    public static ScoreManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void ScoreUp(int damage)
    {
        score += damage;
        UpdateScoreText();
    }

    public void ScoreDown(int damage)
    {
        score -= damage;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        ScoreText.text = "Score " + score.ToString();
    }

}

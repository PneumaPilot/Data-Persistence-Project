using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI scoreField;

    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreField.SetText("HIGH SCORE: " + scoreManager.highScoreName + ": " + scoreManager.highScore);
    }

    public void SetName()
    {
        scoreManager.playerName = inputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        scoreField.SetText("HIGH SCORE: " + scoreManager.highScoreName + ": " + scoreManager.highScore);
    }
}

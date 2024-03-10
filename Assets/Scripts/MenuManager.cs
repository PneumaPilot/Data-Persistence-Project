using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI scoreField;

    // Start is called before the first frame update
    void Start()
    {
        scoreField.SetText("HIGH SCORE: " + ScoreManager.Instance.highScoreName + ": " + ScoreManager.Instance.highScore);
    }

    public void SetName()
    {
        ScoreManager.Instance.playerName = inputField.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

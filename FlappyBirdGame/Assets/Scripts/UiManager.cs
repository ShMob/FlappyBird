using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiManager : MonoBehaviour
{
    public GameObject losePanel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI loseScoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(500, 800, FullScreenMode.FullScreenWindow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void Lose()
    {
        losePanel.SetActive(true);
        scoreText.text = "";
        loseScoreText.text = score.ToString();
        Time.timeScale = 0;
        FindObjectOfType<PipePlacer>().enabled = false;
        FindObjectOfType<BirdController>().enabled = false;
    }
}

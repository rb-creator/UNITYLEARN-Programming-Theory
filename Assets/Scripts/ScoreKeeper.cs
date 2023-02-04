using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + GameManager.Instance.Score;
    }
}

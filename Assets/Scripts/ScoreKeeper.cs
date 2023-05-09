using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    void Update()
    {
        UpdateScore(); //ABSTRACTION
    }

    void UpdateScore() //ABSTRACTION
    {
        ScoreText.text = "Score: " + GameManager.Instance.Score;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private int _score;
    public int Score { get { return _score; } }

    private void Awake()
    {
        ImplementSingleton();
    }

    private void ImplementSingleton()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int points)
    {
        _score += points;
        //Debug.Log(_score);
    }

    public void ActivatePowerUp()
    {
        Debug.Log("PowerUp Activated!");
    }

    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private int _score;

    [SerializeField]
    private int _arrows;

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
        Debug.Log(_score);
    }

    public void ActivatePowerUp()
    {
        // code for activating power-up
    }
}

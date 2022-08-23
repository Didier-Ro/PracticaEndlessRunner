using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject _gameOverText = default;
    [SerializeField] private GameObject _playAgainbutton = default;
    [SerializeField] private GameObject _returnButton = default;
    [SerializeField] private TextMeshProUGUI _scoreText = default;
    private int _score = 0;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void IncreaseScore()
    {
        _score += 15;
        _scoreText.text = $"Distance: {_score}";
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _gameOverText.SetActive(true);
        _playAgainbutton.SetActive(true);
        _returnButton.SetActive(true);
    }
}

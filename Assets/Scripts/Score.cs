using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI _textMesh;
    private int _currentScore = 0;

    public int ScoreToWin { get; set; }
    public Action WinScoreReachedEvent;
    
    private void Awake()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseScore(int value = 1)
    {
        _currentScore += value;
        _textMesh.text = _currentScore.ToString();
        
        if (_currentScore >= ScoreToWin)
            WinScoreReachedEvent?.Invoke();
    }
}
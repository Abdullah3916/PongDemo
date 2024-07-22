using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerPaddleController _playerPaddle;
    [SerializeField] private ComputerPaddleController _computerPaddle;
    [SerializeField] private BallController _ball;
    [SerializeField] private TMP_Text _playerScoreText;
    [SerializeField] private TMP_Text _computerScoreText;
    private int _playerScore;
    private int _computerScore;
    private static GameManager _instance;

    private void Awake()
    {
        if (_instance == null && _instance == this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public static GameManager Instance
    {
        get{ { return _instance; } }
    }
    public void PlayerScores() 
    {
        _playerScore++;
        this._playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores() 
    {
        _computerScore++;
        this._computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound() 
    {
        this._playerPaddle.PaddleResetPosition();
        this._computerPaddle.PaddleResetPosition();
        this._ball.ResetPosition();
        this._ball.AddStartingForce();
    }

}

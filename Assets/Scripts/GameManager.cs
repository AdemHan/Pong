using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;   //Top turunde ve top adinda bir degisken olusturduk.

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public Text playerScoreText;

    public Text computerScoreText;

    private int _playerScore;   //oyuncu skoru icin bir degisken olusturduk

    private int _computerScore;     //bilgisayar skoru icin bir degisken olusturduk

    public void PlayerScores()      // Oyuncu skoru islemlerini yapacak bir method olusturduk
    {
        _playerScore++;     //oyuncunun skorunu bir arttýr

        this.playerScoreText.text = _playerScore.ToString();    //text dosyasi icineoyuncu skorunu yaz
        ResetRound();
    }

    public void ComputerScores()        // bilgisayarýn skoru islemlerini yapacak bir method olusturduk
    {
        _computerScore++;       //bilgisayarin skorunu bir arttýr

        this.computerScoreText.text = _computerScore.ToString();    //text dosyasi icine bilgisayar skorunu yaz
        ResetRound();
    }

    public void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();       //bu top nesnesinin pozisyonunu resetle
        this.ball.AddStartingForce();
    }
}

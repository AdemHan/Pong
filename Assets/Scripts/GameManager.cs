using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;   //Top turunde ve top adinda bir degisken olusturduk.

    private int _playerScore;   //oyuncu skoru icin bir degisken olusturduk

    private int _computerScore;     //bilgisayar skoru icin bir degisken olusturduk

    public void PlayerScores()      // Oyuncu skoru islemlerini yapacak bir method olusturduk
    {
        _playerScore++;     //oyuncunun skorunu bir artt�r
        Debug.Log(_playerScore);

        this.ball.ResetPosition();      //bu top nesnesinin pozisyonunu resetle
        
    }

    public void ComputerScores()        // bilgisayar�n skoru islemlerini yapacak bir method olusturduk
    {
        _computerScore++;       //bilgisayarin skorunu bir artt�r
        Debug.Log(_computerScore);

        this.ball.ResetPosition();       //bu top nesnesinin pozisyonunu resetle
    }
}

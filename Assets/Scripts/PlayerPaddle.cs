using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;  //raketin y�n�n� tutacak

    private void Update()  //bir tusa basilip basilmadigibi ogrendik ve y�n atamasi yaptik
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) )
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) )
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }
    private void FixedUpdate()  //fizik islemlerinde daha stabil calistigi icin bu fonksiyonu kullandik
    {
        if (_direction.sqrMagnitude != 0)   //y� bilgisi girildi mi diye soruyoruz. Eger girildiyse 0 dan farkli oluyor bu deger.
        {
            _rigidbody.AddForce(_direction * this.speed);  //rigidbodymize bu y�nde ve belirledigimiz hiz da kuvvet uyguluyoruz.
        }
    }

}

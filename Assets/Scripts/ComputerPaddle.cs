using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)    //top saga dogru hareket ediyorsa hýz * yon pozitif olur
        {
            if (this.ball.position.y > this.transform.position.y)    //topun yuksekligi bilgisayar raketinin y noktasindan yukaridaysa
            {
                _rigidbody.AddForce(Vector2.up * this.speed);   //bilgisayar raketine yukari dogru speed hizinda kuvvet uygula
            }

            else if (this.ball.position.y < this.transform.position.y)   //topun yuksekligi 0 noktasindan asagidaysa
            {
                _rigidbody.AddForce(Vector2.down * this.speed);     //bilgisayar raketine asagi dogru speed hizinda kuvvet uygula
            }
        }

        else
        {
            if (this.transform.position.y > 0.0f)   //bilgisayar raketinin y'si 0 dan buyukse
            {
                _rigidbody.AddForce(Vector2.down * this.speed);    //bilgisayar raketine asagi yönde kuvvet uygula
            }

            else if (this.transform.position.y < 0.0f)    //bilgisayar raketinin y'si 0 dan kucukse
            {
                _rigidbody.AddForce(Vector2.up * this.speed);    ////bilgisayar raketine yukari yönde kuvvet uygula
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float BouncyStrength;    //BouncyStrength adinda bir public float degiskeni tanimlaniyor. Bu degisken, top yuzeyine carpildiginda ziplama gucunu belirleyecektir.

    private void OnCollisionEnter2D(Collision2D collision)    //OnCollisionEnter2D adinda bir private metot tanimlaniyor.Bu metot, bu script'in bagli oldugu oyun nesnesi (BouncySurface) ile sahnede baska bir nesne arasinda bir carpisma oldugunda tetiklenen bir olay isleyicisidir.
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();    

        if (ball != null)     //Eger carpisan nesne bir top ise devam eder, degilse islem sonlandirilir.
        {
            Vector2 normal = collision.GetContact(0).normal;    //Carpismanin gerceklestigi noktadaki normal vektoru alinir. Carpisma noktalari, "kontak" nesneleriyle temsil edilir ve burada 0 indeksi kullanilarak ilk kontak noktasi alinir.
            ball.AddForce(-normal * this.BouncyStrength);    //Topa ters yonde bir kuvvet uygulanir. Bu kuvvet, carpisma noktasinin normal vektorunun ters yonunde(ters itme) ve BouncyStrength degiskeniyle carparak belirlenir.Böylece top ziplama gucune sahip olur.
        }
    }
}



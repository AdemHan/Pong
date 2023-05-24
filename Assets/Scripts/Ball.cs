using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();    //Baslangicta _rigidbody degiskenine scriptin bagli oldugu nesnenin rigidbodysini atamasini s�yledik
    }

    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()  //topun baslangicdaki gucu ve yonu burada belirleniyor
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;  //x yonu icin Random value kullanmamizin nedeni 0 ve 1 araliginda degerler uretmesi. Bu random deger eger 0.5 ten kucukse -1, buyukse +1 degerini alacak.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :        //ayni sekilde random deger kucukse -1 ve -0.5 arasinda deger uretilecek.
                                        Random.Range(0.5f, 1.0f);           //buyukse 0.5 ve 1 araliginda deger �retilip y degiskenine atanacak. X ten niye farkli yaptik diyecek olursak cevab� su: x te saga mi sola mi gidecegine mi karar verdik. Y'de aciyi 0 a yak�n olmasin ki d�md�z gitmesin istedik.

        Vector2 direction = new Vector2(x, y);      //y�n adinda bir degisken atayip y�n degerlerini x ve y olarak atadik
        _rigidbody.AddForce(direction * this.speed);        // bu rigidbodye kuvvet ekledik. Form�l�n� de kuvvet * h�z olarak girdik
    }
}

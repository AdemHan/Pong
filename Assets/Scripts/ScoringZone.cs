using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;      //Unity'nin event sistemini kullarak tetikleme islemi icin yeni bir degisken atadik

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();      //OnCollisionEnter2D adinda bir private metot tanimlaniyor.Bu metot, bu script'in bagli oldugu oyun nesnesi  ile sahnede baska bir nesne arasinda bir carpisma oldugunda tetiklenen bir olay isleyicisidir.

        if (ball != null)       //Eger carpisan nesne bir top ise devam eder, degilse islem sonlandirilir.
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}

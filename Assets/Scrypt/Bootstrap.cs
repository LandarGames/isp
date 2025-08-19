using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private KartData _card;
    [SerializeField] private power[] _power;

    public void NewCard()
    {
        GameObject card = Instantiate(_card._objects[Random.Range(0,_card._objects.Length)],transform.position,Quaternion.identity, transform);
        if (card.GetComponent<Hero>().Power == null)
        {
            card.GetComponent<Hero>().Power = _power[Random.Range(0, _power.Length)];
        }

        card.GetComponent<Hero>().UseKart();


    }
}

using UnityEngine;

public class power : Card
{
    public int powerOchki;
    public override void UseKart()
    {
        //Debug.Log($"Создана карта: {Name} тип размещения: {Type} специальная способность "");
    }

    public string Opis()
    {
        return $"{name}, очки силы {powerOchki}";
    }
}

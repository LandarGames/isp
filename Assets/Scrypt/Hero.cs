using UnityEngine;

public class Hero : Card
{
    public power Power;
    public override void UseKart()
    {
        Debug.Log($"Создана карта: {Name} тип размещения: {Type} специальная способность: {Power.Opis()} ");
    }
}

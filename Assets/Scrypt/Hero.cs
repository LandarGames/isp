using UnityEngine;

public class Hero : Card
{
    public power Power;
    public override void UseKart()
    {
        Debug.Log($"������� �����: {Name} ��� ����������: {Type} ����������� �����������: {Power.Opis()} ");
    }
}

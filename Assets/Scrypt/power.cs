using UnityEngine;

public class power : Card
{
    public int powerOchki;
    public override void UseKart()
    {
        //Debug.Log($"������� �����: {Name} ��� ����������: {Type} ����������� ����������� "");
    }

    public string Opis()
    {
        return $"{name}, ���� ���� {powerOchki}";
    }
}

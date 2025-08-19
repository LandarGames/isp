using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public string Name;
    public Sprite Icon;
    public string opis;
    public string Type;
    public int MethodType;



    public abstract void UseKart();

}

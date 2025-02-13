using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject 
{
    public string cardName;
    public string description;
    public Sprite artwork;
    public int manaCost;
    public int health;

}

using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField]
    public string swordName
    {
        get { return swordName; }
    }

    [SerializeField]
    public string Description
    {
        get { return Description; }
    }
    
    [SerializeField]
    public Sprite Icon
    {
        get { return Icon; }
    }

    [SerializeField]
    public int GoldCost
    {
        get { return GoldCost; }
    }

    [SerializeField]
    public int AttackDamage
    {
        get { return AttackDamage; }
    }
}

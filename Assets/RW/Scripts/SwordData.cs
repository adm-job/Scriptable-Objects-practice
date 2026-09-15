using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField]
    private string swordName;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int goldCost;
    [SerializeField]
    private int attackDamage;
}

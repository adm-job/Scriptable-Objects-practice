using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]
    private SwordData swordData;

    [SerializeField]
    private GameEvent OnSwordSelected;

    private void OnMouseDown()
    {
        OnSwordSelected.Raise();

        Debug.Log(swordData.name);
        Debug.Log(swordData.Description);
        Debug.Log(swordData.Icon.name);
        Debug.Log(swordData.GoldCost);
        Debug.Log(swordData.AttackDamage);
    }
}

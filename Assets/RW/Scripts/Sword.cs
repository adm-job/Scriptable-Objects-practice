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
    }
}

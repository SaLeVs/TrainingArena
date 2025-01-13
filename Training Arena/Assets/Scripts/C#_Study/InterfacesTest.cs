using UnityEngine;
using static Interfaces;

public class InterfacesTest : MonoBehaviour, IAttackable
{
    private void Start()
    {
        Damage();
    }

    public void Damage()
    {
        Debug.Log("Player damage on interface test");
    }
}

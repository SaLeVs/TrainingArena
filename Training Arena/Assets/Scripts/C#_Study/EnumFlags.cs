using System;
using UnityEngine;

public class EnumFlags : MonoBehaviour
{
    // Work with enums as a bitmask

    [Flags]
    public enum  Abillity : byte // to save memory
    {
        None    = 0,
        jump    = 1 << 0,
        Sprint  = 2 << 1,
        Shoot   = 4 << 2,
        Fly     = 8 << 3
    }

    private void Start()
    {
        Abillity playerAbilities = Abillity.jump | Abillity.Shoot;
        Debug.Log(playerAbilities);

        Debug.Log(playerAbilities.HasFlag(Abillity.jump)); // True

#if TEST // THIS IS NOT INCLUDED IN THE BUILD
        Debug.Log("Testing is defined");
#endif
    }
}

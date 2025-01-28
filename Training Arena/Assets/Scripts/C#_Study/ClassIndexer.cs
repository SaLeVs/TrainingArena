using System;
using UnityEngine;

public class ClassIndexer : MonoBehaviour
{
    // Acess data from your custom class as if it were an array

    private void Start()
    {
        PlayerStats playerStats = new PlayerStats()
        {
            strAmount = 12,
            dexAmount = 56,
            wisAmount = 36
        };

        int strenght = playerStats[0];
        Debug.Log(strenght); // 12, now we can acess parameters with index
        playerStats[0] = 15;
        Debug.Log(playerStats[0]); // 15

    }

    public class  PlayerStats
    {
        public enum Stat
        {
            Str,
            Dex,
            Wis
        }
    
        public int strAmount;
        public int dexAmount;
        public int wisAmount;

        public int this[int index] // here we can put anything, like a enum
        {
            get
            {
                switch (index)
                {
                    case 0: return strAmount;
                    case 1: return dexAmount;
                    case 2: return wisAmount;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: strAmount = value; break;
                    case 1: dexAmount = value; break;
                    case 2: wisAmount = value; break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
    }
}

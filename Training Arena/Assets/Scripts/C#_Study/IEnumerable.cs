using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnumerable : MonoBehaviour
{
    // Learn how to make your custom typs with foreach

    private void Start()
    {
        List<int> intList = new List<int>();
        PlayerStats playerStats = new PlayerStats();

        foreach (Stat stat in playerStats)
        {
            Debug.Log(stat);
        }
    }

    public class PlayerStats : IEnumerable<Stat>
    {
        public Stat dex = new Stat { name = "Dexterity", value = 12 };
        public Stat str = new Stat { name = "Strength", value = 28 };
        public Stat wis = new Stat { name = "Wisdom", value = 35 };

        public IEnumerator<Stat> GetEnumerator()
        {
            return new PlayerStatEnumerator(this);

            // yield return dex;    
            // yield return str;
            // yield return wis;
            // if we do have a fix number of elements, we can do that
            // this function we be called multiple times, the firts with dex, the second with str and the third with wis
            
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class PlayerStatEnumerator : IEnumerator<Stat>
        {
            private PlayerStats playerStats;
            private int index;

            public PlayerStatEnumerator(PlayerStats playerStats)
            {
                this.playerStats = playerStats;
                index = -1;
            }

            public Stat Current
            {
                get
                {
                    switch (index)
                    {
                        default:
                        case 0: return playerStats.dex;
                        case 1: return playerStats.str;
                        case 2: return playerStats.wis;
                    }
                }
            }

            object IEnumerator.Current => throw new System.NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                index++;
                if(index > 2)
                {
                    index = -1; 
                }
                return index != -1;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }

    public class Stat 
    {
        public string name;
        public int value;

        public override string ToString()
        {
            return name + ": " + value;
        }
    }

    

}

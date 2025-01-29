using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqExample : MonoBehaviour
{
    // Easily do queries on yout data collections

    private void Start()
    {
        List<Player> playerList = new List<Player>
        {
            new Player { playerName = "John", team = "Red" },
            new Player { playerName = "Mike", team = "Blue" },
            new Player { playerName = "Sara", team = "Red" },
            new Player { playerName = "Tom", team = "Blue" },
        };

        List<Player> redPlayerList = playerList.Where(player => player.team == "Red").ToList(); // function where is a LINQ function
        // Interesting functions All, Any, First, intersect, Join

        foreach (Player player in redPlayerList)
        {
            Debug.Log(player);
        }

        IEnumerable<Player> redPlayerIEnumerable = // is the same thing, but this is the LINQ syntax
            from player in playerList
            where player.team == "Red"
            select player;

        foreach(Player player in redPlayerIEnumerable)
        {
            Debug.Log(player);
        }
    }

    //LINQ works on all IEnumerable collections and IQueryable

    public class Player
    {
        public string playerName;
        public string team;


        public override string ToString()
        {
            return playerName + ", " + team;
        }
    }
}

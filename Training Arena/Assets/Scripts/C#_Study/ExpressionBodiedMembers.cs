using UnityEngine;

public class ExpressionBodiedMembers : MonoBehaviour
{
    // Super compact way to define logic with 1 instruction

    public class Player
    {
        public string playerName;

        //public string GetPlayerName()
        //{
        //    return playerName;
        //}
        public string GetPlayerName() => playerName;    // instead of the above, use this expression-bodied member

        // if we choose this way, we can't use the {} brackets
        // this can be used for one unique instruction

        public void SetPlayerName(string _playerName) => this.playerName = _playerName;

        public string PlayerName
        {
            get => playerName;
            set => playerName = value;
        } 

        public Player(string _playerName) => playerName = _playerName; // constructor
        // if the constructor has only one instruction, we can use this expression-bodied member, if have more than one, we can't use it

    }

}

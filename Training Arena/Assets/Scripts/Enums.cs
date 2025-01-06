using UnityEngine;

public class Enums : MonoBehaviour
{

    public int enemy;

    private enum PlayerAction // we define enum like this
    {
        NoEnemy,
        NoPathToEnemy,
        MovingTowardEnemy,
        AttackingEnemy
    }

    private PlayerAction GetNextPlayerAction() // and the method its Player acaction, because return a type of enum
    {
        if(enemy == 0)
        {
            return PlayerAction.NoEnemy;
        }

        if (enemy < 0)
        {
            return PlayerAction.NoPathToEnemy;
        }

        if (enemy > 0)
        {
            return PlayerAction.MovingTowardEnemy;
        }

        if(enemy > 1)
        {
            return PlayerAction.AttackingEnemy;
        }

        return PlayerAction.NoEnemy;
    }



    private enum State 
    {
        LookingForEnemy,
        MovingToEnemy,
        AttackingEnemy
    }

    private State state;
    private void HandleState()
    {
        switch (state)
        {
            case State.LookingForEnemy:
                break;
        }
    }
}

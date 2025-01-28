using UnityEngine;

public class RefOutIn : MonoBehaviour
{
    // Get multiple pieces of data from a function, or make something a reference


    private void Start()
    {
        Unit unit = new Unit();
        //  State state = unit.GetUnitsState(45);  this dont work because the parameter is out
        int healthAmount;
        State state = unit.GetUnitsState(out healthAmount); // the value can be null because in function will be assigned

        unit.GetUnitsState2(out State _state, out int _healthAmount, out string _name); // we can return multiple values with out parameters, and can create variables in the same line

        Debug.Log(healthAmount);

        // for use ref we need to define the variable before
        State state2 = State.Idle;
        int healthAmount2 = 50;
        string names = "GuiAlves";

        unit.GetUnitsState3(ref state2, ref healthAmount2, ref names); // 
    }

    public enum State
    {
        Idle,
        Patrolling,
        Attacking
    }

    public class Unit 
    {
        
        public UnitData GetUnitState()
        {
            return new UnitData // we can return multiple values with return of type class
            {
                state = State.Idle,
                healthAmount = 56,
                name = "Code Monkey"
            };
        }

        public State GetUnitsState(out int health)
        {
            health = 100; // this is the value that will be returned, because it is an out parameter
            return State.Patrolling;
        }

        public void GetUnitsState2(out State state, out int healthAmount, out string name) // the piece of data that arrives here will be defined here in this function
        {
            state = State.Attacking;
            healthAmount = 100;
            name = "Gui";
        }

        public void GetUnitsState3(ref State state, ref int healthAmount, ref string name) // the piece of data that arrives here will be defined here in this function
        {
            state = State.Attacking; // with ref  we dont need to define value here
            healthAmount = 100;
            name = "Gui";
        }

        // the kwyword in is used to make the variable read-only
        // using with structs


        public class UnitData
        {
            public State state;
            public int healthAmount;
            public string name;
        }

    }
}

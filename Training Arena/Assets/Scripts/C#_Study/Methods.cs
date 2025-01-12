using UnityEngine;

public class Methods : MonoBehaviour
{
    // void means that methods dont return values

    int x, y;
    int playerHealth = 100;
    int atackEnemy = 10;
    int currentHealth;

    public void Start()
    {
        x = 5;
        y = 10;
        currentHealth = 50;
        Debug.Log(QuantityOfAttacks(playerHealth, atackEnemy, currentHealth));
    }


    int Subtraction(int valueA, int valueB)
    {
        // if you dont put return, the method will be underline with red trace

       int result = valueA - valueB;
       return result;
    }
    
    int QuantityOfAttacks(int totalLife, int enemyAttack, int currentLife)
    {

        int quantityOfAttacks = (totalLife - currentLife) / enemyAttack;
        return quantityOfAttacks;
    }


    void UpdateValues()
    {
        int result;
        result = x + y;

        print(result);
        // we can use print only for monobehaviour scripts
        // Debug log works on all unity
    }

    void MultiplyValues (int valueA, int valueB)
    {
        int result;

        result = valueA * valueB;

        Debug.Log(result);
        // we can use same names for local variables

    }
}

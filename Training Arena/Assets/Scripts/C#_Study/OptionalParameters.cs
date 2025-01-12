using UnityEngine;

public class OptionalParameters : MonoBehaviour
{
    // Add defatuls to function parameters to make them optional

    private enum AttackType
    {
        Melee,
        Ranged,
        Magic
    }

    private void Start()
    {
        SpawnEnemy(Vector3.zero, AttackType.Melee, 100);
        SpawnEnemys(Vector3.zero, AttackType.Melee);
        SpawnEnemys(Vector3.zero, AttackType.Melee, _healthAmount: 55); // we can use the name of the parameter to define the value, and put : to define the value
    }

    private void SpawnEnemy(Vector3 _spawnPos, AttackType _attackType, int _healthAmount) // if we use this, all parameters
    {
        Debug.Log("Spawn pos: " + _spawnPos + ", Attack Type: " + _attackType + ", Health: " + _healthAmount);
    }
    private void SpawnEnemys(Vector3 _spawnPos, AttackType _attackType, int _healthAmount = 100) // if we define value when we call the function, we cant need to pass all parameters
    {
        Debug.Log("Spawn pos: " + _spawnPos + ", Attack Type: " + _attackType + ", Health: " + _healthAmount);
    }

    // we need to put optional parameters at the end of the function, mandatory parameters must be at the beginning
    // we can use the value default to make the parameter optional
    // using constants can be good for creating default values

}

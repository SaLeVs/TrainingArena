using UnityEngine;

public class Functions : MonoBehaviour
{
    
    public void Start()
    {
        SayHello();
        SayPlayerName("FólleN");
        AddNumbers(5, 10);
        Debug.Log(SubtractNumbers(1000, 7)); // we can debug functions
    }

    void SayHello()
    {
        Debug.Log("Hello");
    }

    void SayPlayerName(string _playerName)
    {
        Debug.Log(_playerName);
    }

    int AddNumbers(int x, int y)
    {
        int result;

        result = x + y;

        return result;
    }

    int SubtractNumbers(int x, int y)
    {
        return x - y;
    }
}

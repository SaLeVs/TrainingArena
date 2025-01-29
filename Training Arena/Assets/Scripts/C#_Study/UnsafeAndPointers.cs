using UnityEngine;

public class UnsafeAndPointers : MonoBehaviour
{
    // Bypass C# safety features and work with raw memory
    // we have to enable this to work on unity


    private void Start()
    {
        unsafe
        {
            int* intArrayPointer = stackalloc int[10];
            for(int i = 0; i < 20; i++) // this not will throw an error because the stackalloc is a unsafe method
            {
                intArrayPointer[i] = i;
            }

            GameData gameData = new GameData();
            GameData* gameDataPointer = &gameData;
            gameDataPointer->score = 10; // this is a pointer to a struct

            int a = 5;
            PowerTwo(&a);
        }
    }

    public struct GameData
    {
        public int score;
        public bool isGameOver;
    }

    public static unsafe void PowerTwo(int* value)
    {
        *value *= *value;
    }
}

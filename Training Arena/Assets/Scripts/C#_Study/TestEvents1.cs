using System;
using UnityEngine;

public class TestEvents1 : MonoBehaviour
{
    public event Action OnGameStart;


    public void Start()
    {
        Debug.Log("Jogo iniciado!");
        OnGameStart?.Invoke();
    }
    
}

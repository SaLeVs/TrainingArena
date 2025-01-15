using System;
using Unity.VisualScripting;
using UnityEngine;

public class TestEvents2 : MonoBehaviour
{
    [SerializeField] private TestEvents1 testEvents1;

    private void Start()
    {
        testEvents1.OnGameStart += TestEvents1_OnGameStart;
    }
    
    private void TestEvents1_OnGameStart()
    {
        Debug.Log("Confirmo que o jogo começou");
    }
}

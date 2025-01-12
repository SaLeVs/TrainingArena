using UnityEngine;

public class Cases : MonoBehaviour
{

    public enum Personagens
    {
        IronMan,
        Groot,
        SpiderMan
    }

    void Start()
    {
        Debug.Log(1 == 1); // we can check infos on debug

        if (1 < 2)
            Debug.Log("false"); // we can make a if with one line

        SwitchTest(Personagens.IronMan); // we dont need to create a global variable, we can change on loop call
    }

    private void SwitchTest(Personagens character)
    {
        switch (character)
        {
            default: // default is important for localize bugs
                Debug.Log("Character not recognized");
                break;
            case Personagens.IronMan:
                Debug.Log("I`m Iron Man");
                break;
            case Personagens.Groot:
                Debug.Log("I`m Groot");
                break;
            case Personagens.SpiderMan:
                Debug.Log("I can`t save Gween");
                break;
        }
    }
}

using UnityEngine;

public class SingletonPattern : MonoBehaviour
{
    // Very useful pattern when you have only a dingle instance of a thing


    private void Start()
    {
        Debug.Log(GameManager.Instance);
        GameManager.Instance.TestFunction();
        
    }

    public class GameManager 
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null) 
                {
                    instance = new GameManager();
                }
                return instance;
            }
            
        }

        private GameManager()   
        {
           
        }

        public void TestFunction()
        {
            Debug.Log("Test function");
        }
    }



}

using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    // The easiest way to save persistent data in Unity is to use PlayerPrefs.

    private void Awake()
    {
        PlayerPrefs.SetInt("playerLevel", 5); // its a key-value pair

        Debug.Log(PlayerPrefs.GetInt("playerLevel")); // the code is case sensitive, if we change the key to "playerlevel" we will get 0

        // this really saves, if we play the editor again and delete line 9, we will get the same value on line 11

        // PlayerPrefs.HaskKey("playerLevel") returns true if the key exists

        SaveObject saveObject = new SaveObject()
        {
            playerName = "S4LeV",
            playerLevel = 56,
            playerPosition = new Vector3(5, 0, 3)
        };

        //JsonUtility.ToJson(saveObject); // this will convert the object to a json string
        PlayerPrefs.SetString("SaveObject", JsonUtility.ToJson(saveObject));
        PlayerPrefs.Save();

        // PlayerPrefs saves the data in the registry on windows

    }

    private void SetBool(string key, bool value) // here we are creating a method to save a bool value
    {
        PlayerPrefs.SetInt(key, value ? 1 : 0);
    }

    private bool GetBool(string key)
    {
        return PlayerPrefs.GetInt(key) == 1;
    }

    // On Documentation we have more info about playerPrefs

    [System.Serializable]
    public class SaveObject
    {
        public string playerName;
        public int playerLevel;
        public Vector3 playerPosition;
    }
}

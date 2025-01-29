using System;
using System.IO;
using UnityEngine;

public class IDisposableExample : MonoBehaviour
{
    // Add support for using code blocks to your custom classes for clean up

    private void Start()
    {
        using (FileStream fileStream = File.Open("file.txt", FileMode.Open)) // Error, file is not closed
        {
            fileStream.Read(new Span<byte>()); // Error, file is not closed
        }

        using (SaveSystem saveSystem = new SaveSystem())
        {
           saveSystem.SavePlayerData();
           saveSystem.SaveObjectData();
        }
    }

    public class SaveSystem : IDisposable
    {
        private FileStream fileStream;

        public SaveSystem()
        {
            fileStream = File.Open("file.txt", FileMode.Open);
        }

        public void SavePlayerData()
        {

        }

        public void SaveObjectData()
        {

        }

        public void Dispose()
        {
            Debug.Log("Dispose");
            fileStream.Dispose();
        }

        ~SaveSystem()
        {
            Debug.Log("Finalize");
            Dispose();
        }
    }
}

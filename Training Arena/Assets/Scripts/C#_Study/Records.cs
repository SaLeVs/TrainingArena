using UnityEngine;
using System.Runtime.CompilerServices;

public class Records : MonoBehaviour
{
    // Simple way to group data into a type

    public record Person(string FirstName, string LastName)
    {
        public string FirstName { get; set; } = FirstName;
        public string LastName { get; set; } = LastName;
        // Records cant be changed after they are created
        // this is valid code that can be changed for unity
    }

    public record Person3(string FirstName, string LastName); // Because the namespace on the final of code, this is valid code that can be changed for unity


    private void Start()
    {
        Person person = new("Gui", "Alves");
        Person person2 = person with { FirstName = "Gui3" };
        Debug.Log(person2);
        person.FirstName = "Gui2";
        Debug.Log(person);
    }
}


namespace System.Runtime.CompilerServices
{
    public class IsExternalInit
    {
        
    }

}


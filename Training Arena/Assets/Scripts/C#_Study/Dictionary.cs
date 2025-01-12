using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{

    // Collection that stores key-value pairs

    private enum ResourceType
    {
        Wood,
        Stone,
        Iron
    }

    private enum HeroType
    {
        Thor,
        Hulk,
        BlackWidow
    }
    
    Dictionary<HeroType, int> heroes = new Dictionary<HeroType, int>
    {
        { HeroType.Thor, 300 },
        { HeroType.Hulk, 800 },
        { HeroType.BlackWidow, 1000 }
    };

    // Unity dont serialize dictionaries, so you cant see it in the inspector

   

    private void Start()
    {
        Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>(); // the way to create a dictionary

        resourceTypeAmountDictionary.Add(ResourceType.Wood, 10); // adding a key-value pair
        resourceTypeAmountDictionary.Add(ResourceType.Stone, 20);
        resourceTypeAmountDictionary.Add(ResourceType.Iron, 30);

        Debug.Log(resourceTypeAmountDictionary[ResourceType.Stone]); // accessing a value by key


        resourceTypeAmountDictionary[ResourceType.Stone] = 25; // changing a value by key
        Debug.Log(resourceTypeAmountDictionary[ResourceType.Stone]); // just debunging the  newvalue

        Debug.Log(resourceTypeAmountDictionary.ContainsKey(ResourceType.Iron)); // checking if a key exists

        if (resourceTypeAmountDictionary.TryGetValue(ResourceType.Wood, out int woodAmount)) 
        {
            Debug.Log(woodAmount); 

        }

        heroes[HeroType.Thor] = 1000;
        heroes.Remove(HeroType.Hulk); 
        heroes.Clear();

        // important Methods

        if(heroes.ContainsKey(HeroType.Thor)) // verifying if a key exists
        {
            Debug.Log("Thor is in the dictionary");
        }
        

        if (heroes.ContainsValue(1000)) // verifying if a value exists
        {
            Debug.Log("There is a hero with 1000 power");
        }
        

        if(heroes.TryGetValue(HeroType.Hulk, out int hulkPower)) // getting a value by key
        {
            Debug.Log("Hulk's power is " + hulkPower);
        }
        
    }
}

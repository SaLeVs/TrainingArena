using Mono.Cecil;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // test of dictionarys serialization

    public enum ResourceType
    {
        Wood,
        Stone,
        Iron,
        Gold
    }

    [SerializeField] private Dictionary<ResourceType, int> resourceTypeAmountDictionary;

    [Serializable]
    public class ResourceTypeAmount
    {
        public ResourceType resourceType;
        public int amount;
    }

    [SerializeField] private List<ResourceTypeAmount> resourceTypeAmountList;

    private void Awake()
    {
        resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();
        foreach (ResourceTypeAmount resourceTypeAmount in resourceTypeAmountList)
        {
            resourceTypeAmountDictionary[resourceTypeAmount.resourceType] = resourceTypeAmount.amount;
        }

        Debug.Log("Dictionary: ");
        foreach(ResourceType resourceType in resourceTypeAmountDictionary.Keys)
        {
            Debug.Log(resourceType + ": " + resourceTypeAmountDictionary[resourceType]);
        }
    }
    
}

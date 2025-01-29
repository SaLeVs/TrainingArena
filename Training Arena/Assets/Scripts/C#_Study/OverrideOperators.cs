using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class OverrideOperators : MonoBehaviour
{
    // Add suport for doind +-*/==!= on your custom types

    private void Start()
    {
        ResourceAmount resourceAmount1 = new ResourceAmount { resourceType = ResourceType.Wood, amount = 5 };
        ResourceAmount resourceAmount2 = new ResourceAmount { resourceType = ResourceType.Wood, amount = 5 };
        // ResourceAmount resourceAmountTotal = resourceAmount1 + resourceAmount2; we cant make this math operation
        ResourceAmount resourceAmountTotal = resourceAmount1 + resourceAmount2; // now this work because the code on line 31
        Debug.Log(resourceAmountTotal); // Wood: 17
        Debug.Log(resourceAmount1 == resourceAmount2); // True, here we can use the .Equals function now
        Debug.Log(resourceAmount1.GetHashCode() + " " + resourceAmount2.GetHashCode()); 

        List<ResourceAmount> resourceAmountList = new List<ResourceAmount>
        {
            new ResourceAmount { resourceType = ResourceType.Wood, amount = 5 },
            new ResourceAmount { resourceType = ResourceType.Wood, amount = 5 },
            new ResourceAmount { resourceType = ResourceType.Gold, amount = 5 }
        };

        Debug.Log(resourceAmountList.Contains(new ResourceAmount { resourceType = ResourceType.Gold, amount = 12 })); // False, we need to implement the IEquatable interface
    }

    public enum ResourceType
    {
        Wood,
        Gold
    }

    public class ResourceAmount : IEquatable<ResourceAmount>
    {
        public ResourceType resourceType;
        public int amount;

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this, obj))
            {
                return true;
            }

            if(ReferenceEquals(obj, null))
            {
                return false;
            }

            if(obj is ResourceAmount)
            {
                return this == (ResourceAmount)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(resourceType, amount);
        }

        public override string ToString()
        {
            return resourceType + ": " + amount;
        }

        public static ResourceAmount operator +(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB) // inside on this function we can add logic for make sense
        {
            return new ResourceAmount
            {
                resourceType = resourceAmountA.resourceType,
                amount = resourceAmountA.amount + resourceAmountB.amount
            };
        }

        public static bool operator ==(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return resourceAmountA.resourceType == resourceAmountB.resourceType && 
                   resourceAmountA.amount == resourceAmountB.amount;
        }

        public static bool operator !=(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return !(resourceAmountA == resourceAmountB);
        }

        public bool Equals(ResourceAmount other)
        {
            if(ReferenceEquals(other, null))
            {
                return false;
            }

            return this == other;
        }
    }
}

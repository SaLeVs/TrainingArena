using System;
using UnityEngine;

[Serializable]  // This attribute allows the class to be serialized in the Unity Editor
public class Attributes : MonoBehaviour
{
    // Add Metadata to your code

    [SerializeField] private float moveSpeed = 5f;  // This attribute makes the variable visible in the Unity Editor

    private void Start()
    {
       typeof(Player).GetCustomAttributes(typeof(IsObjectTypeAttribute), false); // This method returns an array of all attributes applied to the class
    }

    [IsObjectType(ObjectType.Unit)] // This attribute is a custom attribute
    public class Player
    {

    }

    public enum ObjectType
    {
        Unit,
        Object,
        Prop
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class IsObjectTypeAttribute : Attribute
    {
        private ObjectType objectType;

        public IsObjectTypeAttribute(ObjectType _objectType)
        {
            this.objectType = _objectType;
        }
    }
}

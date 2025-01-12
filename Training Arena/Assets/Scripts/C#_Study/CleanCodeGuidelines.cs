using UnityEngine;

public class CleanCodeGuidelines : MonoBehaviour
{
    // Various tips for helping you write better more readable and easy to understand code

    // Clean code = easy to understand and easy to modify

    // Avoid maigc numbers
    // Managing complexity through information hiding
    // Single responsibility principle
    // Group related logic/data together
    // avoid comments when possible
    // Constantly thinl about refactoring
    // Never use strings as identifiers
    // Always default to private, only use public when absolutely needed
    // Keep functions shorts and concise
    // Dont repeat yourself

    private void AvoidMagicNumbers()
    {
        int distance = 0;
        int goalPoint = 5;

        if(distance < 5)
        {
            // dont use the five, instead of this
        }

        if (distance < goalPoint)
        {
            // we uderstand all reading the line 30

        }
        


    }

    private void NeverUseStringsAsIdentifiers()
    {
        Transform childSpriteTransform = transform.Find("Sprite"); // if this dont match 100%, does not work, and the compiler dont will tell for you
        SpriteRenderer childSpriteRenderer = childSpriteTransform.GetComponent<SpriteRenderer>();
        childSpriteRenderer.color = Color.red;
    }

    private void ManagingComplexity()
    {
        // Its good write all private
        // Filds will be protect
    }

    private void SingleResponsibilityPrinciple()
    {
       // When you create a function, this function have to do onething
       // for identifier this, if you can put the word and on the function name, this function have to be 2 functions
    }

    private void GroupRelatedLogicData()
    {
        // Instead of use data on script, we can change like this

        
    }

    private PlayerStats playerStats;

    public class PlayerStats
    {
        private int strength;
        private int dexterity;
        private int wisdom;

    }
}

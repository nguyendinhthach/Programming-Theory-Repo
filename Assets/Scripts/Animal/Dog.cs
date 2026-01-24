using Unity.VisualScripting;
using UnityEngine;

public class Dog : Animal // INHERITANCE
{
    private void OnMouseDown()
    {
        AnimalSound(); // POLYMORPHISM
    }
    public override void AnimalSound() // ABSTRACTION + POLYMORPHISM
    {
        PlaySound(); // ENCAPSULATION 
        Debug.Log($"Dog {AnimalName} barks"); // ENCAPSULATION – getter
    }
}

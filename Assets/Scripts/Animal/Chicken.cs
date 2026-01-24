using UnityEngine;

public class Chicken : Animal // INHERITANCE
{
    private void OnMouseDown()
    {
        AnimalSound(); // POLYMORPHISM
    }
    public override void AnimalSound() // ABSTRACTION + POLYMORPHISM
    {
        PlaySound(); // ENCAPSULATION 
        Debug.Log($"{AnimalName} crows"); // ENCAPSULATION – getter
    }
}

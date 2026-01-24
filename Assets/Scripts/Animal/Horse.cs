using UnityEngine;

public class Horse : Animal // INHERITANCE
{
    private void OnMouseDown()
    {
        AnimalSound(); // POLYMORPHISM
    }
    public override void AnimalSound() // ABSTRACTION + POLYMORPHISM
    {
        PlaySound(); // ENCAPSULATION 
        Debug.Log($"{AnimalName} neighs"); // ENCAPSULATION – getter
    }
}

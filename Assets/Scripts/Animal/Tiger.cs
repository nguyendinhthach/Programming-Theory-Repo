using UnityEngine;

public class Tiger : Animal // INHERITANCE
{
    private void OnMouseDown()
    {
        AnimalSound(); // POLYMORPHISM
    }
    public override void AnimalSound() // ABSTRACTION + POLYMORPHISM
    {
        PlaySound(); // ENCAPSULATION 
        Debug.Log($"Tiger {AnimalName} roars"); // ENCAPSULATION – getter
    }
}

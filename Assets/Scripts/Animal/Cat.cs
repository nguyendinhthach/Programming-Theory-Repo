using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    private void OnMouseDown()
    {
        AnimalSound(); // POLYMORPHISM
    }
    public override void AnimalSound() // ABSTRACTION + POLYMORPHISM
    {
        PlaySound(); // ENCAPSULATION 
        Debug.Log($"{AnimalName} meows"); // ENCAPSULATION – getter
    }
}

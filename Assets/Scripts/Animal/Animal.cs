using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] private string animalName;
    [SerializeField] private AudioClip animalSound;

    public string AnimalName => animalName;

    protected void PlaySound()
    {
        AudioSource.PlayClipAtPoint(animalSound, transform.position);
    }

    public abstract void AnimalSound();
}

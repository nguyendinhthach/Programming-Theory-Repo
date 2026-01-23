using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;

    public void StartGame()
    {
        if (!string.IsNullOrWhiteSpace(nameInput.text))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Enter your name to join the game");
        }
    }
}

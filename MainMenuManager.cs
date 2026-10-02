using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Puzzle_Room");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

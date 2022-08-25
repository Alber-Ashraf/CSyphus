using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject Diffculty;
    [SerializeField] private GameObject Story;

    private string sceneToLoad = "Easy";

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Quit()
    {
        Debug.Log("Bye");
        Application.Quit();
    }

    public void story()
    {
        menu.SetActive(false);
        Story.SetActive(true);
    }
    public void diffculty()
    {
        menu.SetActive(false);
        Diffculty.SetActive(true);
    }

    public void Return()
    {
        Story.SetActive(false);
        menu.SetActive(true);
    }

    public void Easy()
    {
        sceneToLoad = "Easy";
        Diffculty.SetActive(false);
        menu.SetActive(true);
    }
    public void Normal()
    {
        sceneToLoad = "Normal";
        Diffculty.SetActive(false);
        menu.SetActive(true);
    }
    public void Hard()
    {
        sceneToLoad = "Hard";
        Diffculty.SetActive(false);
        menu.SetActive(true);
    }
}

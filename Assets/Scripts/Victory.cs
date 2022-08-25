using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject victory;
    [SerializeField] private GameObject credits;

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        victory.SetActive(false);
        credits.SetActive(true);
    }

    public void Return()
    {
        credits.SetActive(false);
        victory.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] private playerMovement maleMovement;
    [SerializeField] private float restartDelay;
    [SerializeField] private Animator maleAnimator;

    bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        MovementDeActivation();
        maleAnimator.SetTrigger("Dead");
        Invoke("MovementActivation", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void MovementActivation()
    {
        maleMovement.enabled = true;
    }

    void MovementDeActivation()
    {
        maleMovement.enabled = false;
    }
}

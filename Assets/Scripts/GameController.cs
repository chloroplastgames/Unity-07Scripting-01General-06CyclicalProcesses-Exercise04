using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private void OnEnable()
    {
        EndPoint.Execute += GameOver;
    }
    private void OnDisable()
    {
        EndPoint.Execute -= GameOver;
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}

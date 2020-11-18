using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    #region Unity Methods
    private void OnEnable()
    {
        EndPoint.FinishTheGame += GameOver;
    }

    private void OnDisable()
    {
        EndPoint.FinishTheGame -= GameOver;
    }
    #endregion

    #region My Methods
    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    #endregion
}

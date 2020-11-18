using UnityEngine;

public class EndPoint : MonoBehaviour
{
    #region Delegates and Events
    public delegate void FinishGame();
    public static event FinishGame FinishTheGame;
    #endregion

    private bool isEnter = false;

    private void OnTriggerEnter()
    {
        if (!isEnter)
        {
            FinishTheGame?.Invoke();
            isEnter = true;
        }
    }

}

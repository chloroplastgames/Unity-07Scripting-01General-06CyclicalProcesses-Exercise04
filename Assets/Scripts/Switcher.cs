using UnityEngine;

public class Switcher : MonoBehaviour
{
    #region Delegates and Events
    public delegate void OpenDoor();
    public static event OpenDoor OpenTheDoor;
    #endregion

    private bool isSwitched = false;
    private void OnTriggerEnter()
    {
        if (!isSwitched)
        {
            OpenTheDoor?.Invoke();
            isSwitched = true;
        }
    }
}

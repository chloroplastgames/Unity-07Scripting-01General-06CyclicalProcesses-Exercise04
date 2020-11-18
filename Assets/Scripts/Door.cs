using UnityEngine;

public class Door : MonoBehaviour
{
    #region Unity Methods
    private void OnEnable()
    {
        Switcher.OpenTheDoor += OpenDoor;
    }

    private void OnDisable()
    {
        Switcher.OpenTheDoor -= OpenDoor;
    }
    #endregion


    #region My Methods
    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
    }
    #endregion

}

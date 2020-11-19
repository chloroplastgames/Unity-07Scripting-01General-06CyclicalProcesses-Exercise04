using UnityEngine;

public class Door : MonoBehaviour
{

    private void OnEnable()
    {
        Switcher.Execute += OpenDoor;
    } 
    private void OnDisable()
    {
        Switcher.Execute -= OpenDoor;
    } 

    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
    }

}

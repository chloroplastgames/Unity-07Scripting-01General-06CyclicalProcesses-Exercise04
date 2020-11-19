using UnityEngine;

public class Door : MonoBehaviour
{
    private Switcher _switcher;

    private void Awake()
    {
        _switcher = FindObjectOfType<Switcher>();
    }

    private void OnEnable()
    {
        _switcher.OnTrigger += OpenDoor;
    }

    private void OnDisable()
    {
        _switcher.OnTrigger -= OpenDoor;
    }


    private void OpenDoor()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
        _switcher.OnTrigger -= OpenDoor;
    }
}

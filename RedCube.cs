using UnityEngine;

public class RedCube : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.onEventManger += onRotate; //load event
    }
    private void OnDisable()
    {
        EventManager.onEventManger -= onRotate; // unload event
    }

    void onRotate(bool dir)
    {
        if (dir)
        {
            transform.Rotate(transform.up, 45);
        }
        else
        {
            transform.Rotate(transform.up, -45);
        }
    }
}

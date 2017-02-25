using UnityEngine;

public class GreenCube : MonoBehaviour
{

    private void OnEnable()
    {
        EventManager.onEventManger += onMove; // load event
    }
    private void OnDisable()
    {
        EventManager.onEventManger -= onMove; // unload event
    }

    void onMove(bool dis)
    {
        if (dis)
        {
            transform.position += transform.up;

        }
        else
        {
            transform.position -= transform.up;
        }
    }
}

using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void myDelegate(bool del); // define the method signature

    public static myDelegate onEventManger; // define the event

    void myEvent(bool del)
    {
        onEventManger(del);
    }

}

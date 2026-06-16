using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public bool isOpen = false;
    public Vector3 closedPosition;
    public Vector3 openPosition;
    public float speed = 3f; // How fast the door slides

    void Start()
    {
        // Remember where the door started
        closedPosition = transform.localPosition;
        
        // Calculate the open position (e.g., slide 2 units to the right along the X axis)
        // You can adjust this vector depending on which way your door needs to slide!
        openPosition = closedPosition + new Vector3(2f, 0f, 0f); 
    }

    void Update()
    {
        // Smoothly move the door toward the target position every frame
        if (isOpen)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, openPosition, Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, closedPosition, Time.deltaTime * speed);
        }
    }

    // Call this function to open/close the door
    public void ToggleDoor()
    {
        isOpen = !isOpen;
    }
}
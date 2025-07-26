using UnityEngine;
using UnityEngine.InputSystem;

public class Shrink : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 shrinkScale = new Vector3(0.5f, 0.5f, 1f);
    void Start()
    {
        originalScale = transform.localScale;
    }


    void FixedUpdate()
    {
        if (Keyboard.current.qKey.isPressed)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, shrinkScale, Time.deltaTime * 10);
        }
        else if (Keyboard.current.eKey.isPressed)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime * 10);
        }
    }
}

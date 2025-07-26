using UnityEngine;
using UnityEngine.InputSystem;

public class Shrink : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 bigScale;
    public Vector3 smallScale = new Vector3(0.5f, 0.5f, 1f);
    private bool isSmall = false;
    private bool wasSmall = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bigScale = transform.localScale;
    }


    void FixedUpdate()
    {
        if (Keyboard.current.qKey.isPressed)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, smallScale, Time.deltaTime * 20);
            isSmall = true;
        }
        else if (Keyboard.current.eKey.isPressed)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, bigScale, Time.deltaTime * 20);
            isSmall = false;
        }

        if (isSmall != wasSmall)
        {
            UpdateMass();
            wasSmall = isSmall;
        }
    }

    void UpdateMass()
    {
        rb.mass = isSmall ? 1f : 50f;
    }
}

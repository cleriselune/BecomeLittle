using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Camera mainCamera;
    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && GameObject.FindObjectsByType<Point>(FindObjectsSortMode.None).Length == 0)
        {
            mainCamera.transform.position = new Vector3(collision.transform.position.x + 15, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
    }
}

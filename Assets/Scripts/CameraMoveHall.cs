using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMoveHall : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Point.totalPoints == 3)
        {
            SceneManager.LoadScene("Kitchen");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMoveKitchen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Point.totalPoints == 6)
        {
            SceneManager.LoadScene("LivingRoom");
        }
    }
}

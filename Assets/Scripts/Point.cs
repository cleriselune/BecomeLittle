using UnityEngine;

public class Point : MonoBehaviour
{
    public static int totalPoints = 0;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            totalPoints++;
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
    }

}

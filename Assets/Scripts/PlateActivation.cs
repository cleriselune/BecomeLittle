using UnityEngine;

public class PlateActivation : MonoBehaviour
{
    public GameObject point;
    void Start()
    {
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Player"))
        {
            if (point != null)
            {
                point.SetActive(true);
            }
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            if (point != null)
            {
                point.SetActive(false);
            }
        }
    }

}

using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour
{
    public GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Point.totalPoints == 7 || Point.totalPoints == 1)
        {
            Debug.Log("you win");
            canvas.SetActive(true);
        }
    }
}

using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{

    
    public float moveSpeed = 5f;

    

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);

    }
}

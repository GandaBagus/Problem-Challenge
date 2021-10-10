using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        ScoreScript.scoreValue += 10;
        if (other.gameObject.tag == "Spawnable")
        {
            Destroy(other.gameObject);
        }
    }
}
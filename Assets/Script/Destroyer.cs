using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Spawner sp;

    void OnCollisionEnter2D(Collision2D other)
    {
        ScoreScript.scoreValue += 10;
        if (other.gameObject.tag == "Spawnable")
        {
            Destroy(other.gameObject);
            sp.spawnObject();
        }
        
           
       
    }
}
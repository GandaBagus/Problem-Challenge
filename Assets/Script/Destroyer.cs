using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Spawner sp;
    public AudioSource tickSource;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        ScoreScript.scoreValue += 10;
        if (other.gameObject.tag == "Spawnable")
        {
            
            Destroy(other.gameObject);
            sp.spawnObject();
            tickSource.Play();
        }    
    }
}
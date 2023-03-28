using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerScript playerScript;
    public ScoreScript Score;  // we will call this script when player collides with red cube
    public GameControllerScript GameController;
    public AudioSource CollectableAudio;
    public AudioSource GameOverAudio;
    public GameObject Explosion;
    public GameObject PlayerDisappearAfterHit;

    private void OnTriggerEnter(Collider other)     //This is executed when two game objects collide //other represent another object collider which collides with player
    {
        //Debug.Log(other.gameObject.name);  To know the name of game objects being collided by the player
        if (other.gameObject.tag == "Collectibles")
        {
            CollectableAudio.Play();
            Score.AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacles")
        {
            GameOverAudio.Play();          
            Instantiate(Explosion,transform.position, Quaternion.identity);
            PlayerDisappearAfterHit.GetComponent<Renderer>().enabled = false;
            playerScript.enabled = false;
            GameController.GameOver();
        }
    }

}

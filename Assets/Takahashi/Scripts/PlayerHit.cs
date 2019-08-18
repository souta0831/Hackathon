using UnityEngine;

public class PlayerHit : MonoBehaviour
{

    public void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag ("Obstacle"))
        {
            GameObject.Find ("GameManager").SendMessage ("OnGameOver");
        }
    }


}

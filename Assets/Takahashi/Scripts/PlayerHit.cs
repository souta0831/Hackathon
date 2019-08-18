using UnityEngine;

public class PlayerHit : MonoBehaviour
{

    public void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag ("Obstacle"))
        {
            GameObject.Find ("GameManager").SendMessage ("OnGameOver");
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce (new Vector3 (0, 4f, 5f), ForceMode.Impulse);
            rb.AddRelativeTorque (new Vector3 (10f, 0, 0), ForceMode.Impulse);
        }

    }


}

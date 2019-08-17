using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    [Range (0.001f, 1f)]
    private float animSpeed = 0.001f;

    private Animator animator;
    private PedalManager pedalManager;

    private void Start ()
    {
        animator = GetComponent<Animator> ();
        pedalManager = GameObject.Find ("SpeedManager").GetComponent<PedalManager> ();
    }

    private void Update ()
    {
        animator.SetFloat ("Speed", pedalManager.GetNowSpeed () * animSpeed);
    }
}

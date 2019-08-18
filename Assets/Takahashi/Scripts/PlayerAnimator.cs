using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //アニメーションのスピード
    [SerializeField]
    [Range (0.001f, 1f)]
    private float animSpeed = 0.001f;

    //アニメーター
    private Animator animator;
    //スピード管理クラス
    private PedalManager pedalManager;

    private void Start ()
    {
        //取得
        animator = GetComponent<Animator> ();
        pedalManager = GameObject.Find ("SpeedManager").GetComponent<PedalManager> ();
    }

    private void Update ()
    {
        //進行スピードとアニメーションを同期
        animator.SetFloat ("Speed", pedalManager.GetNowSpeed () * animSpeed);
    }
}

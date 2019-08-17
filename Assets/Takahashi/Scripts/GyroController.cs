using UnityEngine;

public class GyroController : MonoBehaviour
{

    //重力の強さ
    [SerializeField] private float gravity = 1f;

    //移動範囲(真ん中からの最大距離)
    [SerializeField]
    private float maxMoveRange = 3f;

    //スピードの倍率
    [SerializeField]
    [Range (0.1f, 1f)]
    private float speedMag = 0.5f;

    //回転速度の倍率
    [SerializeField]
    [Range (0.001f, 1f)]
    private float rotationMag = 0.5f;

    //傾きを戻そうとする係数
    [SerializeField]
    [Range (0.001f, 1f)]
    private float fixRotationCoe = 0.05f;

    //物理挙動
    private Rigidbody rb;

    //デバイスの傾きのZ軸を格納する変数
    private float deviceRotZ, playerRotZ;


    private void Start ()
    {
        //ジャイロセンサーを有効化
        Input.gyro.enabled = true;

        rb = GetComponent<Rigidbody> ();
    }

    private void Update ()
    {
#if UNITY_EDITOR    //エディタで動いているとき
        //キーボード操作で傾く処理
        EditorLean ();

#else   //エディタではないとき
        //ジャイロで傾く処理
        Lean ();

#endif
        //左右移動の処理
        Move ();
    }

    private void FixedUpdate ()
    {
        //重力
        rb.AddForce (Vector3.down * gravity);
        //デバイスの傾きを利用してトルクを加える
        rb.AddRelativeTorque (new Vector3 (0, 0, deviceRotZ * rotationMag));
        //傾きを直そうとするトルクを少しだけかける
        rb.AddRelativeTorque (new Vector3 (0, 0, -playerRotZ * fixRotationCoe));
    }

    //エディタ用の処理
    private void EditorLean ()
    {
        //キーボードのAとD (または左と右の矢印キー)
        float h = Input.GetAxis ("Horizontal");
        //入力されている間、回転する
        //transform.Rotate (0, 0, -h * 100f * Time.deltaTime);
        //回転するZ軸
        deviceRotZ = -h * 15f;
    }

    //ジャイロセンサーで傾いて、そっちの方向に移動
    private void Lean ()
    {
        //ジャイロセンサーの値を取得
        Quaternion gyro = Input.gyro.attitude;
        //実際のスマホの回転になるように変換
        Quaternion deviceRot = Quaternion.Euler (90, 0, 0) * new Quaternion (-gyro.x, -gyro.y, gyro.z, gyro.w);
        //プレイヤーの角度をZ軸だけ適用
        deviceRotZ = FixedAngle (deviceRot.eulerAngles.z);
        //transform.eulerAngles = new Vector3 (0, 0, deviceRot.eulerAngles.z);
    }

    //左右移動の処理
    private void Move ()
    {
        //プレイヤーのx軸座標を角度に応じたスピードで移動
        playerRotZ = FixedAngle (transform.eulerAngles.z);
        transform.position = new Vector3 (
           //動ける範囲でx座標を移動
           Mathf.Clamp (transform.position.x - playerRotZ * speedMag * Time.deltaTime, -maxMoveRange, maxMoveRange),
           0,
           0
        );
    }

    //角度が180°より大きいときは、-180〜0°に変換
    private float FixedAngle (float angle)
    {
        if (angle > 180f)
        {
            angle = -360f + angle;
        }
        return angle;
    }
}


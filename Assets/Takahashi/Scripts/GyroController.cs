using UnityEngine;

public class GyroController : MonoBehaviour
{

    [SerializeField]
    private float maxMoveRange = 3f;

    [SerializeField] [Range (0.1f, 1f)]
    private float speedMag = 0.5f;


    private void Start ()
    {
        //ジャイロセンサーを有効化
        Input.gyro.enabled = true;
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

    //エディタ用の処理
    private void EditorLean ()
    {
        //キーボードのAとD (または左と右の矢印キー)
        float h = Input.GetAxis ("Horizontal");
        //入力されている間、回転する
        transform.Rotate (0, 0, -h * 100f * Time.deltaTime);
    }

    //ジャイロセンサーで傾いて、そっちの方向に移動
    private void Lean ()
    {
        //ジャイロセンサーの値を取得
        Quaternion gyro = Input.gyro.attitude;
        //実際のスマホの回転になるように変換
        Quaternion deviceRot = Quaternion.Euler (90, 0, 0) * new Quaternion (-gyro.x, -gyro.y, gyro.z, gyro.w);
        //プレイヤーの角度をZ軸だけ適用
        transform.eulerAngles = new Vector3 (0, 0, deviceRot.eulerAngles.z);
    }

    //左右移動の処理
    private void Move ()
    {
        //プレイヤーのZ軸の角度だけを取得
        float rotZ = transform.eulerAngles.z;
        //角度が180°より大きいときは、-180〜0°に変換
        if (rotZ > 180f)
        {
            rotZ = -360f + rotZ;
        }
        //プレイヤーのx軸座標を角度に応じたスピードで移動
        transform.position = new Vector3 (
                //動ける範囲でx座標を移動
                Mathf.Clamp (transform.position.x - rotZ * speedMag * Time.deltaTime, -maxMoveRange, maxMoveRange),
                0,
                0
             );
    }
}


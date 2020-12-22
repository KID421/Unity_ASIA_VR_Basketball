using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;

    // OTE 條件：
    // 兩個碰撞物件 其中一個 必須勾選 IsTrigger
    // 要偵測此腳本子物件是否產生碰撞
    // 必須添加剛體 Rigidbody
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Animator anim;
    // Tối ưu hóa bằng Hash (thay vì tìm string mỗi frame)
    private static readonly int SpeedHash = Animator.StringToHash("Speed");

    void Start() { anim = GetComponent<Animator>(); }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        // Set tốc độ chạy
        anim.SetFloat(SpeedHash, Mathf.Abs(move));

    
    }
}

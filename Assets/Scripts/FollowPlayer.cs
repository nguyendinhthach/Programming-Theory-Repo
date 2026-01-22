using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 1.6f, 0);

        // Lấy rotation yaw của player
        float yaw = player.transform.eulerAngles.y;

        // Nếu muốn thêm pitch offset (ví dụ nhìn xuống 10 độ)
        float pitch = 10f; 

        // Gán rotation cho camera
        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
    }
}

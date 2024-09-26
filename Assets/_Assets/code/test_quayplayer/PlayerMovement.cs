using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Kiểm tra nếu người dùng chạm vào màn hình
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Lấy vị trí chạm trên màn hình
            Vector2 touchPosition = touch.position;

            // Chia màn hình thành 2 nửa
            float screenMiddle = Screen.width / 2;

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                // Nếu chạm vào bên trái màn hình
                if (touchPosition.x < screenMiddle)
                {
                    MoveLeft();
                }
                // Nếu chạm vào bên phải màn hình
                else if (touchPosition.x > screenMiddle)
                {
                    MoveRight();
                }
            }
        }
    }

    // Hàm di chuyển sang trái
    void MoveLeft()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    // Hàm di chuyển sang phải
    void MoveRight()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}

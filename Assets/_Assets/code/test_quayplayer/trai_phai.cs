using UnityEngine;

public class trai_phai : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private bool isMovingRight = false;
    private bool isMovingLeft = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Di chuyển nếu đang giữ nút
        if (isMovingRight)
        {
            phaimover();
        }
        else if (isMovingLeft)
        {
            traimover();
        }
        else
        {
            dung();
        }
    }

    // Các phương thức sẽ được gán cho sự kiện OnPointerDown/OnPointerUp từ nút
    public void StartMoveRight()
    {
        isMovingRight = true;
    }

    public void StopMoveRight()
    {
        isMovingRight = false;
    }

    public void StartMoveLeft()
    {
        isMovingLeft = true;
    }

    public void StopMoveLeft()
    {
        isMovingLeft = false;
    }

    public void traimover()
    {
        rb.MovePosition(transform.position + new Vector3(-1, 0.0f, 0f) * speed * Time.deltaTime);
        Debug.Log("Đã di chuyển trái");
    }

    public void phaimover()
    {
        rb.MovePosition(transform.position + new Vector3(1, 0.0f, 0f) * speed * Time.deltaTime);
        Debug.Log("Đã di chuyển phải");
    }

    public void dung()
    {
        rb.MovePosition(transform.position);
        Debug.Log("Đã dừng");
    }
}

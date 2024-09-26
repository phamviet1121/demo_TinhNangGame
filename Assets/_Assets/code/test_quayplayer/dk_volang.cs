using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dk_volang : MonoBehaviour
{
    public GameObject player; // GameObject của nhân vật player
    public RectTransform wheelCenter; // Tâm vô lăng (img2) 
    public RectTransform wheelFrame;  // Khung vô lăng (img1)

    
    public float rotationSpeed = 12f;
    //void Start()
    //{
    //    // Lưu vị trí ban đầu của tâm vô lăng
    //    initialPosition = wheelCenter.anchoredPosition;
    //}

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;


            Vector3 directionToPlayer = mousePosition - wheelCenter.position;
            float angle = Mathf.Atan2(directionToPlayer.y, -directionToPlayer.x) * Mathf.Rad2Deg;


            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
    }

    //void Start()
    //{
    //    // Lưu vị trí ban đầu của tâm vô lăng
    //    initialPosition = wheelCenter.anchoredPosition;
    //}

    //void Update()
    //{
    //    // Hàm xử lý xoay vô lăng
    //    HandleSteering();
    //}

    //void HandleSteering()
    //{
    //    // Khi người dùng nhấn chuột trái
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        // Lấy vị trí của chuột
    //        Vector2 mousePos = Input.mousePosition;
    //        // Kiểm tra xem chuột có đang nằm trong khung vô lăng không

    //        // Bắt đầu xoay vô lăng
    //        isSteering = true;
    //        // Lưu lại góc ban đầu của vô lăng
    //        initialAngle = GetWheelAngle();
    //        Debug.Log("Đã nhấn vào trong khung vô lăng");

    //    }

    //    // Khi người dùng giữ chuột và đang xoay vô lăng
    //    if (Input.GetMouseButton(0) && isSteering)
    //    {
    //        // Lấy vị trí của chuột
    //        Vector2 mousePos = Input.mousePosition;
    //        // Tính toán hướng của chuột so với tâm vô lăng
    //        Vector2 direction = mousePos - (Vector2)wheelCenter.position;

    //        // Tính toán góc hiện tại dựa trên hướng của chuột
    //        float currentAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //        // Tính toán sự thay đổi góc so với góc ban đầu
    //        float rotationDelta = currentAngle - initialAngle;

    //        // Giới hạn góc xoay của vô lăng (ví dụ từ -180 đến 180 độ)
    //        wheelCenter.localEulerAngles = new Vector3(0, 0, Mathf.Clamp(rotationDelta, -180f, 180f));

    //        // Xoay player theo góc xoay của vô lăng
    //        player.transform.rotation = Quaternion.Euler(0, 0, -rotationDelta); // Xoay theo trục Z
    //        Debug.Log("Đang quay vô lăng và player");
    //    }

    //    // Khi người dùng thả chuột
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        // Dừng xoay vô lăng
    //        isSteering = false;
    //        Debug.Log("Vừa thả chuột");
    //    }
    //}

    //// Hàm tính toán góc của vô lăng so với vị trí ban đầu
    //float GetWheelAngle()
    //{
    //    // Tính toán góc dựa trên vị trí của chuột và tâm vô lăng
    //    Vector2 direction = (Vector2)Input.mousePosition - (Vector2)wheelCenter.position;
    //    return Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //}

    //// Di chuyển tâm vô lăng theo vị trí chuột, nhưng chỉ trong khung vô lăng
    //public void MoveWheelCenter(Vector2 mousePosition)
    //{
    //    Debug.Log("co chay ko");
    //    Vector2 wheelFramePos = wheelFrame.position;
    //    float wheelRadius = wheelFrame.rect.width / 2; // Bán kính của khung vô lăng

    //    // Tính khoảng cách giữa vị trí chuột và tâm khung vô lăng
    //    Vector2 direction = mousePosition - wheelFramePos;
    //    float distance = direction.magnitude;

    //    // Nếu chuột nằm ngoài khung, giới hạn vị trí của tâm vô lăng trong khung
    //    if (distance > wheelRadius)
    //    {
    //        direction = direction.normalized * wheelRadius;
    //    }

    //    // Cập nhật vị trí mới cho tâm vô lăng
    //    wheelCenter.anchoredPosition = direction;
    //}
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;

//public class dk_volang : MonoBehaviour
//{
//public GameObject player; // GameObject của nhân vật player
//public RectTransform wheelCenter; // Tâm vô lăng (img2) 
//public RectTransform wheelFrame;  // Khung vô lăng (img1)

//private Vector2 initialPosition; // Lưu vị trí ban đầu của tâm vô lăng
//private float initialAngle; // Lưu góc ban đầu khi người dùng bắt đầu xoay vô lăng
//private bool isSteering; // Biến để kiểm tra xem người dùng có đang xoay vô lăng không

//void Start()
//{
//    // Lưu vị trí ban đầu của tâm vô lăng
//    initialPosition = wheelCenter.anchoredPosition;
//}

//void Update()
//{
//    // Hàm xử lý xoay vô lăng
//    HandleSteering();
//}

//void HandleSteering()
//{
//    // Khi người dùng nhấn chuột trái
//    if (Input.GetMouseButtonDown(0))
//    {
//        // Lấy vị trí của chuột
//        Vector2 mousePos = Input.mousePosition;

//        // Bắt đầu xoay vô lăng
//        isSteering = true;
//        // Lưu lại góc ban đầu của vô lăng
//        initialAngle = GetWheelAngle();
//        Debug.Log("Đã nhấn vào trong khung vô lăng");

//    }

//    // Khi người dùng giữ chuột và đang xoay vô lăng
//    if (Input.GetMouseButton(0) && isSteering)
//    {
//        // Lấy vị trí của chuột
//        Vector2 mousePos = Input.mousePosition;
//        // Tính toán hướng của chuột so với tâm vô lăng
//        Vector2 direction = mousePos - (Vector2)wheelCenter.position;

//        // Tính toán góc hiện tại dựa trên hướng của chuột
//        float currentAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//        // Tính toán sự thay đổi góc so với góc ban đầu
//        float rotationDelta = currentAngle - initialAngle;

//        // Thay đổi góc quay của vô lăng mà không giới hạn
//        wheelCenter.localEulerAngles += new Vector3(0, 0, rotationDelta);

//        // Xoay player theo góc xoay của vô lăng
//        player.transform.rotation = Quaternion.Euler(0, 0, -wheelCenter.localEulerAngles.z); // Xoay theo trục Z
//        Debug.Log("Đang quay vô lăng và player");
//    }

//    // Khi người dùng thả chuột
//    if (Input.GetMouseButtonUp(0))
//    {
//        // Dừng xoay vô lăng
//        isSteering = false;
//        Debug.Log("Vừa thả chuột");
//    }
//}

//// Hàm tính toán góc của vô lăng so với vị trí ban đầu
//float GetWheelAngle()
//{
//    // Tính toán góc dựa trên vị trí của chuột và tâm vô lăng
//    Vector2 direction = (Vector2)Input.mousePosition - (Vector2)wheelCenter.position;
//    return Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//}
//public Transform player; // Tham chiếu đến đối tượng player
//public RectTransform wheelCenter; // Tham chiếu đến tâm vô lăng (img2)
//public RectTransform wheelFrame; // Tham chiếu đến khung vô lăng (img1)

//private float wheelRadius; // Bán kính khung vô lăng

//void Start()
//{
//    // Tính toán bán kính khung vô lăng
//    wheelRadius = wheelFrame.rect.width / 2;
//}

//public void OnDrag(PointerEventData eventData)
//{
//    // Lấy vị trí chuột
//    Vector2 mousePos = eventData.position;

//    // Chuyển đổi vị trí tâm vô lăng sang không gian màn hình
//    Vector2 wheelCenterPos = RectTransformUtility.WorldToScreenPoint(Camera.main, wheelCenter.position);

//    // Tính toán hướng từ tâm vô lăng đến vị trí chuột
//    Vector2 direction = mousePos - wheelCenterPos;

//    // Tính toán khoảng cách
//    float distance = direction.magnitude;

//    // Giới hạn khoảng cách để tâm vô lăng không vượt ra ngoài khung vô lăng
//    if (distance > wheelRadius)
//    {
//        direction.Normalize(); // Chuẩn hóa hướng
//        direction *= wheelRadius; // Giới hạn bán kính
//    }

//    // Cập nhật vị trí tâm vô lăng
//    wheelCenter.position = wheelCenterPos + direction;

//    // Tính toán góc quay
//    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

//    // Cập nhật góc quay của player
//    player.eulerAngles = new Vector3(0, angle, 0);
//}
//}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class test_dk : MonoBehaviour
//{
//    public Transform player;
//    public RectTransform tam;
//    public RectTransform vongtron;
//    public float speed;
//    Vector2 tamvongtron;
//    // Start is called before the first frame update
//    void Start()
//    {
//         tamvongtron=tam.position;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButton(0))
//        {
//            Vector3 vitri_nguoidung_an = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            Vector2 vitrian = new Vector2(vitri_nguoidung_an.x, vitri_nguoidung_an.y);
//            // di chuyen tam den vi trí nguoi dung chon
//            tam.transform.position = Vector2.MoveTowards(tam.transform.position, vitrian, speed * Time.deltaTime);

//        }
//        else
//        {
//            tam.transform.position = Vector2.MoveTowards(tam.transform.position, tamvongtron, (speed+5) * Time.deltaTime);
//        }
//    }
//}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class test_dk : MonoBehaviour
//{
//    public Transform player;
//    public RectTransform tam;
//    public RectTransform vongtron;
//    public float speed;
//    Vector2 tamvongtron;

//    // Bán kính của vòng tròn
//    public float radius;

//    // Start is called before the first frame update
//    void Start()
//    {
//        tamvongtron = tam.position;
//        radius = vongtron.rect.width / 2; // Giả sử vongtron là hình tròn
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButton(0))
//        {
//            Vector3 vitri_nguoidung_an = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            Vector2 vitrian = new Vector2(vitri_nguoidung_an.x, vitri_nguoidung_an.y);

//            // Di chuyển tam đến vị trí người dùng chọn
//            Vector2 newPosition = Vector2.MoveTowards(tam.transform.position, vitrian, speed * Time.deltaTime);

//            // Kiểm tra xem tam có vượt quá vòng tròn không
//            if (Vector2.Distance(newPosition, tamvongtron) <= radius)
//            {
//                tam.transform.position = newPosition;
//            }
//        }
//        else
//        {
//            tam.transform.position = Vector2.MoveTowards(tam.transform.position, tamvongtron, (speed + 5) * Time.deltaTime);
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_dk : MonoBehaviour
{
    public Transform player;
    public RectTransform tam;
    public RectTransform vongtron;
    public float speed;
    Vector2 tamvongtron;

    // Bán kính của vòng tròn
    public float radius = 1f;
    public float radius2 = 2f;
    public float rotationSpeed = 12f;
   
    void Start()
    {
        tamvongtron = tam.position;
        radius = 1f; // Giả sử vongtron là hình tròn
    }

    // Update is called once per frame
    void Update()
    {
        //    Vector3 vitri_nguoidung_an = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector2 vitrian = new Vector2(vitri_nguoidung_an.x, vitri_nguoidung_an.y);
        //    if (Input.GetMouseButton(0) && Vector2.Distance(vitrian, tamvongtron) <= radius2)
        //    {


        //        // Tính toán khoảng cách từ vị trí người dùng đến tamvongtron
        //        Vector2 direction = vitrian - tamvongtron;
        //        float distance = direction.magnitude;



        //        // Nếu khoảng cách lớn hơn bán kính, thì điều chỉnh vị trí
        //        if (distance > radius)
        //        {
        //            direction.Normalize(); // Chuẩn hóa vector
        //            tam.transform.position = tamvongtron + direction * radius; // Đặt tam tại điểm trên vòng tròn
        //        }
        //        else
        //        {
        //            // Di chuyển tam đến vị trí người dùng chọn
        //            tam.transform.position = Vector2.MoveTowards(tam.transform.position, vitrian, speed * Time.deltaTime);
        //        }
        //        Vector2 gocquay = new Vector2(tam.position.x, tam.position.y) - tamvongtron;
        //        float angle = Mathf.Atan2(-gocquay.x, gocquay.y) * Mathf.Rad2Deg;
        //        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        //        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        //    }
        //    else
        //    {
        //        tam.transform.position = Vector2.MoveTowards(tam.transform.position, tamvongtron, (speed + 5) * Time.deltaTime);
        //    }

        ////////////////////////////////////////////////////////////////////


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                Vector3 vitri_nguoidung_an = Camera.main.ScreenToWorldPoint(touch.position);
                Vector2 vitrian = new Vector2(vitri_nguoidung_an.x, vitri_nguoidung_an.y);

                if (Vector2.Distance(vitrian, tamvongtron) <= radius2)
                {
                    Vector2 direction = vitrian - tamvongtron;
                    float distance = direction.magnitude;

                    // Nếu khoảng cách lớn hơn bán kính, thì điều chỉnh vị trí
                    if (distance > radius)
                    {
                        direction.Normalize(); // Chuẩn hóa vector
                        tam.transform.position = tamvongtron + direction * radius; // Đặt tam tại điểm trên vòng tròn
                    }
                    else
                    {
                        // Di chuyển tam đến vị trí người dùng chọn
                        tam.transform.position = Vector2.MoveTowards(tam.transform.position, vitrian, speed * Time.deltaTime);
                    }

                    Vector2 gocquay = new Vector2(tam.position.x, tam.position.y) - tamvongtron;
                    float angle = Mathf.Atan2(-gocquay.x, gocquay.y) * Mathf.Rad2Deg;
                    Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
                    player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
                }
            }
        }
        else
        {
            tam.transform.position = Vector2.MoveTowards(tam.transform.position, tamvongtron, (speed + 5) * Time.deltaTime);
        }
    }

}






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public FixedJoystick joystick; // Joystick được gán từ Editor
    public float rotationSpeed = 1f; // Tốc độ xoay của player

    void Update()
    {
        // Lấy giá trị từ Joystick
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        // Tính góc quay dựa trên trục Joystick
        if (horizontal != 0 || vertical != 0)
        {
            float angle = Mathf.Atan2 (-horizontal,vertical) * Mathf.Rad2Deg;

            // Quay đối tượng chỉ trên trục Z
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

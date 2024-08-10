using UnityEngine;
using UnityEngine.UI;

public class SmoothMoveToMouse : MonoBehaviour
{
    public Image target;
    public Image mouse;
    public float a;     
    public float smoothTime = 0.3f; 
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
       
    }

    void Update()
    {
     
        Vector3 mousePosition = Input.mousePosition;
        Debug.Log($"Vị trí của chuột: {mousePosition}");

        mouse.rectTransform.anchoredPosition = mousePosition;
        Debug.Log($"Vị trí của hình tròn (chuột): {mouse.rectTransform.anchoredPosition}");

        
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log($"Vị trí của tam giác: {targetPosition}");

        
        target.rectTransform.anchoredPosition = targetPosition;

        
        Vector3 difference = mousePosition - targetPosition;

       
        float rotationAngle = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg * (-1) + a;
        transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.forward);

        Vector3 m = new Vector3(mousePosition.x, mousePosition.y, 0);
       
        transform.position = Vector3.SmoothDamp(transform.position, Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 0)), ref velocity, smoothTime);
        m = new Vector3(mousePosition.x, mousePosition.y, 0);
    }
}

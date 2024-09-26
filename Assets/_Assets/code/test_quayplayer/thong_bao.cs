//using UnityEngine;
//using UnityEngine.UI;

//public class thong_bao : MonoBehaviour
//{
//    public Transform player;
//    public Transform dich;
//    public Image thongbao;
//    public Canvas canvas; // Canvas chứa hình ảnh thông báo
//    public float padding = 10f; // Khoảng cách từ thông báo đến rìa canvas

//    void Start()
//    {
//        // Đảm bảo canvas đã được gán
//        if (canvas == null)
//        {
//            canvas = thongbao.GetComponentInParent<Canvas>();
//        }
//    }

//    // Update được gọi mỗi frame
//    void Update()
//    {
//        // Tính vector từ player đến địch
//        Vector3 direction = dich.position - player.position;


//        Vector3 midPoint = player.position + direction;

//        // Chuyển vị trí giữa từ World Space sang Screen Space
//        Vector3 screenPoint = Camera.main.WorldToScreenPoint(midPoint);

//        // Chuyển từ Screen Space sang Canvas Space
//        RectTransformUtility.ScreenPointToLocalPointInRectangle(
//            canvas.transform as RectTransform,
//            screenPoint,
//            canvas.worldCamera,
//            out Vector2 localPoint);

//        // Lấy kích thước của canvas và thông báo
//        RectTransform canvasRect = canvas.transform as RectTransform;
//        RectTransform thongbaoRect = thongbao.rectTransform;

//        // Tính toán giới hạn biên của canvas
//        float canvasWidth = canvasRect.rect.width;
//        float canvasHeight = canvasRect.rect.height;

//        // Kích thước của thông báo
//        float thongbaoWidth = thongbaoRect.rect.width;
//        float thongbaoHeight = thongbaoRect.rect.height;

//        // Đảm bảo thông báo không vượt quá rìa của canvas
//        localPoint.x = Mathf.Clamp(localPoint.x, -canvasWidth / 2 + thongbaoWidth / 2 + padding, canvasWidth / 2 - thongbaoWidth / 2 - padding);
//        localPoint.y = Mathf.Clamp(localPoint.y, -canvasHeight / 2 + thongbaoHeight / 2 + padding, canvasHeight / 2 - thongbaoHeight / 2 - padding);

//        // Đặt lại vị trí của thông báo
//        thongbao.rectTransform.anchoredPosition = localPoint;
//    }
//}

using UnityEngine;
using UnityEngine.UI;

public class thong_bao : MonoBehaviour
{
    //public Transform player;
    //public Transform dich;
    //public Image thongbao;
    //public Canvas canvas; // Canvas chứa hình ảnh thông báo
    //public float padding = 10f; // Khoảng cách từ thông báo đến rìa canvas

    //void Start()
    //{
    //    // Đảm bảo canvas đã được gán
    //    if (canvas == null)
    //    {
    //        canvas = thongbao.GetComponentInParent<Canvas>();
    //    }
    //}

    //// Update được gọi mỗi frame
    //void Update()
    //{
    //    // Tính vector từ player đến địch
    //    Vector3 direction = dich.position - player.position;

    //    Vector3 midPoint = player.position + direction;

    //    //// Chuyển vị trí giữa từ World Space sang Screen Space
    //    Vector3 screenPoint = Camera.main.WorldToScreenPoint(midPoint);

    //    // Chuyển từ Screen Space sang Canvas Space
    //    RectTransformUtility.ScreenPointToLocalPointInRectangle(
    //        canvas.transform as RectTransform,
    //        screenPoint,
    //        canvas.worldCamera,
    //        out Vector2 localPoint);

    //    // Lấy kích thước của canvas và thông báo
    //    RectTransform canvasRect = canvas.transform as RectTransform;
    //    RectTransform thongbaoRect = thongbao.rectTransform;

    //    // Tính toán giới hạn biên của canvas
    //    float canvasWidth = canvasRect.rect.width;
    //    float canvasHeight = canvasRect.rect.height;

    //    // Kích thước của thông báo
    //    float thongbaoWidth = thongbaoRect.rect.width;
    //    float thongbaoHeight = thongbaoRect.rect.height;

    //    // Đảm bảo thông báo không vượt quá rìa của canvas
    //    localPoint.x = Mathf.Clamp(localPoint.x, -canvasWidth / 2 + thongbaoWidth / 2 + padding, canvasWidth / 2 - thongbaoWidth / 2 - padding);
    //    localPoint.y = Mathf.Clamp(localPoint.y, -canvasHeight / 2 + thongbaoHeight / 2 + padding, canvasHeight / 2 - thongbaoHeight / 2 - padding);

    //    // Đặt lại vị trí của thông báo
    //    thongbao.rectTransform.anchoredPosition = localPoint;

    //    // Kiểm tra xem đối tượng 'dich' có nằm trong canvas không
    //    bool isWithinCanvas = screenPoint.z > 0 &&
    //                          screenPoint.x > 0 && screenPoint.x < Screen.width &&
    //                          screenPoint.y > 0 && screenPoint.y < Screen.height;

    //    // Nếu 'dich' nằm trong canvas, ẩn thông báo; ngược lại hiện thông báo
    //    thongbao.enabled = !isWithinCanvas;
    //}
    public Transform player;
    public Transform dich;
    public GameObject thongbaoPrefab; // Prefab thông báo
    public Canvas canvas; // Canvas chứa hình ảnh thông báo
    public float padding = 10f; // Khoảng cách từ thông báo đến rìa canvas

    private GameObject thongbaoInstance; // Instance của thông báo

    void Start()
    {
        // Đảm bảo canvas đã được gán
        if (canvas == null)
        {
            canvas = GetComponentInParent<Canvas>();
        }

        // Tạo ra instance cho thông báo, nhưng tạm thời ẩn nó
        thongbaoInstance = Instantiate(thongbaoPrefab, canvas.transform);
        thongbaoInstance.SetActive(false); // Ẩn thông báo khi bắt đầu
    }

    // Update được gọi mỗi frame
    void Update()
    {
        // Tính vector từ player đến địch
        Vector3 direction = dich.position - player.position;
        Vector3 midPoint = player.position + direction;

        // Chuyển vị trí giữa từ World Space sang Screen Space
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(midPoint);

        // Lấy kích thước của canvas
        RectTransform canvasRect = canvas.transform as RectTransform;

        // Tính toán giới hạn biên của canvas
        float canvasWidth = canvasRect.rect.width;
        float canvasHeight = canvasRect.rect.height;

        // Kiểm tra xem đối tượng 'dich' có nằm trong canvas không
        bool isWithinCanvas = screenPoint.z > 0 &&
                              screenPoint.x > 0 && screenPoint.x < Screen.width &&
                              screenPoint.y > 0 && screenPoint.y < Screen.height;

        // Nếu 'dich' nằm ngoài canvas, hiện thông báo
        if (!isWithinCanvas)
        {
            thongbaoInstance.SetActive(true); // Hiện thông báo

            // Chuyển từ Screen Space sang Canvas Space
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvasRect,
                screenPoint,
                canvas.worldCamera,
                out Vector2 localPoint);

            // Tính toán vị trí của thông báo ở biên canvas
            localPoint.x = Mathf.Clamp(localPoint.x, -canvasWidth / 2 + padding, canvasWidth / 2 - padding);
            localPoint.y = Mathf.Clamp(localPoint.y, -canvasHeight / 2 + padding, canvasHeight / 2 - padding);

            // Đặt lại vị trí của thông báo trên biên của canvas
            RectTransform thongbaoRect = thongbaoInstance.GetComponent<RectTransform>();
            thongbaoRect.anchoredPosition = localPoint;
        }
        else
        {
            // Ẩn thông báo nếu địch nằm trong canvas
            thongbaoInstance.SetActive(false);
        }
    }

}


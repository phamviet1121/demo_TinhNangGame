using UnityEngine;
using UnityEngine.UI;

public class thu_lay_txt : MonoBehaviour
{
    // Biến tham chiếu tới GameObject chứa các Text components


    void Start()
    {
        GameObject textObject = GameObject.Find("nhiem_vu");
        Text[] textComponents = textObject.GetComponents<Text>();
        textComponents[0].text = "Nội dung mới cho Text component thứ hai!";
        // Giả sử bạn muốn thay đổi giá trị của Text component thứ hai (vị trí 1 trong mảng)
        //if (textComponents.Length > 1) // Kiểm tra nếu có ít nhất 2 Text components
        //{
        //    textComponents[1].text = "Nội dung mới cho Text component thứ hai!";
        //}
    }
    // Update is called once per frame
    void Update()
    {

    }
}

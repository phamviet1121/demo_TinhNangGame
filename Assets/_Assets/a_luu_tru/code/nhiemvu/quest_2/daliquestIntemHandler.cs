using System;
using UnityEngine;
using UnityEngine.UI;

public class daliquestIntemHandler : MonoBehaviour
{
    // Tham chiếu đến dữ liệu của nhiệm vụ
    public data_Quest Data_Quest;
    //public Quest_Savedata quest_Savedata;

    //// Các thành phần UI
    //public Text tiendo_thucte_txt;
    //public Image tiendo_img;  // Biến này chưa được sử dụng trong mã hiện tại nhưng giữ lại để đầy đủ
    //public Button trangthai_btn;
    //public Text trangthai_btn_txt;

    // Phương thức để thiết lập dữ liệu nhiệm vụ
    internal void SetData(data_Quest dataQuest/* ,Quest_Savedata quest_Savedata*/)
    {
        this.Data_Quest = dataQuest;
       //this.quest_Savedata = quest_Savedata;
       // UpdateUI();
    }

    //// Phương thức để cập nhật UI dựa trên dữ liệu nhiệm vụ
    //public void UpdateUI()
    //{
    //    if (Data_Quest != null)
    //    {
    //        tiendo_thucte_txt.text = Data_Quest.tiendo_txt_thucte;

    //        // Cập nhật trạng thái của nhiệm vụ
    //        if (Data_Quest.tiendo_txt_thucte == Data_Quest.tiendo_txt_hoanthanh)
    //        {
    //            Data_Quest.trangthai_bl = true;
    //            Data_Quest.trangthai = "đã hoàn thành";
    //        }

    //        trangthai_btn_txt.text = Data_Quest.trangthai;
    //        trangthai_btn.interactable = Data_Quest.trangthai_bl;

    //        trangthai_btn.onClick.RemoveAllListeners();
    //        trangthai_btn.onClick.AddListener(OnButtonClick);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Data_Quest chưa được thiết lập.");
    //    }
    //}

    //// Phương thức xử lý sự kiện nhấn nút
    //void OnButtonClick()
    //{
    //    if (Data_Quest != null)
    //    {
    //        Data_Quest.trangthai = "đã nhận";
    //        Data_Quest.trangthai_bl = false;
    //        UpdateUI();  // Cập nhật lại UI sau khi thay đổi trạng thái
    //    }
    //}
}

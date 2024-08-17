using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_quest : MonoBehaviour
{
    public data_bace_Quest Data_bace_Quest;

    public Text tiendo_thucte_txt;
    public Image tiendo_img;
    public Button trangthai_btn;
    public Text trangthai_btn_txt;
    bool buy;

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        foreach (var data in Data_bace_Quest.DatabaseScripts)
        {
            int id = data.id;
            tiendo_thucte_txt.text = data.tiendo_txt_thucte;

            if (data.tiendo_txt_thucte == data.tiendo_txt_hoanthanh && buy == true)
            {
                data.trangthai_bl = true;
                trangthai_btn.interactable = data.trangthai_bl;

                data.trangthai = "đã hoàn thành";
                trangthai_btn_txt.text = data.trangthai;

                trangthai_btn.AddEventListener(id, OnStatusButtonClick);

            }


        }


    }
    private void OnStatusButtonClick(int id)
    {
        foreach (var data in Data_bace_Quest.DatabaseScripts)
        {
            if (data.id == id)
            {
                data.trangthai = "da nhan";
                trangthai_btn_txt.text = data.trangthai;
            }

        }

    }





















    //public data_Quest data_Quest;
    //public data_bace_Quest Data_bace_Quest;

    //// Các thành phần UI
    //public Text tiendo_thucte_txt;
    //public Image tiendo_img;  // Biến này chưa được sử dụng trong mã hiện tại nhưng giữ lại để đầy đủ
    //public Button trangthai_btn;
    //public Text trangthai_btn_txt;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("da cap nhat tinh trang moi nhat");
    //    UpdateUI();
    //}

    //public void UpdateUI()
    //{
    //    foreach (var data in Data_bace_Quest.DatabaseScripts)
    //    {

    //        tiendo_thucte_txt.text = data.tiendo_txt_thucte;
    //        if (data.tiendo_txt_thucte == data.tiendo_txt_hoanthanh)
    //        {
    //            data.trangthai_bl = true;
    //            data.trangthai = "đã hoàn thành";
    //        }

    //        trangthai_btn_txt.text = data.trangthai;
    //        trangthai_btn.interactable = data.trangthai_bl;

    //        trangthai_btn.onClick.RemoveAllListeners();
    //        int id = data.id;
    //        trangthai_btn.onClick.AddListener(() => OnButtonClick(id));
    //        Debug.LogWarning("vua cap nhat song .");
    //    }
    //}


    //void OnButtonClick(int id)
    //{
    //    foreach (var data in Data_bace_Quest.DatabaseScripts)
    //    {

    //        if (id == data.id)
    //        {
    //            data.trangthai = "đã nhận";
    //            data.trangthai_bl = false;
    //            UpdateUI();  // Cập nhật lại UI sau khi thay đổi trạng thái
    //            Debug.Log("da nhan");
    //        }

    //    }


    //}



    //    if (Data_Quest != null)
    //    {
    //        tiendo_thucte_txt.text = Data_Quest.tiendo_txt_thucte;
    //        Debug.LogWarning($"{tiendo_thucte_txt.text}");
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
    //        Debug.LogWarning("vua cap nhat song .");
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Data_Quest chưa được thiết lập.");
    //    }
    //}

    // Phương thức xử lý sự kiện nhấn nút
    //void OnButtonClick()
    //{
    //    if (Data_Quest != null)
    //    {
    //        Data_Quest.trangthai = "đã nhận";
    //        Data_Quest.trangthai_bl = false;
    //        UpdateUI();  // Cập nhật lại UI sau khi thay đổi trạng thái
    //        Debug.Log("da nhan");
    //    }
    //}
}

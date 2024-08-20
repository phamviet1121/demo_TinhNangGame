using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class questItem : MonoBehaviour
{
    public data_bace_Quest Data_bace_Quest;
    public Image icon_img;
    public Text thongtin_txtt;
    public Text tiendo_ht_txt;
    public Text tiendo_thucte_txt;
    public Image tiendo_img;
    public Button trangthai_btn;
    public Text trangthai_btn_txt;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Setdata(data_Quest data)
    {
        Debug.Log("da chay ham questItem");
        bool danhan = false;
     
        if (data == null)
        {
            Debug.LogWarning("Nh?n d? li?u data_Quest là null.");
            return;
        }


        // Kiểm tra nếu sprite không phải là null trước khi gán
        if (data.anh_img != null)
        {
            icon_img.sprite = data.anh_img;
        }
        else
        {
            Debug.LogWarning("Dữ liệu DataQuest iconImg là null.");
        }
        Debug.Log($"{data.id}");
        thongtin_txtt.text = data.thongtin_txt;
        Debug.Log($"{data.thongtin_txt}");

        tiendo_ht_txt.text = data.tiendo_txt_hoanthanh;

        tiendo_thucte_txt.text = data.tiendo_txt_thucte;
        //Debug.Log($"{data.tiendo_txt_thucte}");
        //Debug.Log($"{danhan}");
        if (data.tiendo_txt_thucte == data.tiendo_txt_hoanthanh && danhan==false)
        {
            //Debug.Log($"{danhan}");
            data.trangthai_bl = true;
            trangthai_btn.interactable = data.trangthai_bl;
            data.trangthai = "da hoan thanh roi ";
            trangthai_btn_txt.text = data.trangthai;

            //trangthai_btn.onClick.AddListener(OnStatusButtonClick);

            trangthai_btn.AddEventListener(data.id, OnStatusButtonClick);
            Debug.Log($"{data.id}");
            
        }
        
        if (trangthai_btn_txt.text == "da nhan")
            {
                danhan=true;
                //data.trangthai_bl = false;
                //data.trangthai = trangthai_btn_txt.text;
            }

        trangthai_btn.interactable = data.trangthai_bl;
       
        trangthai_btn_txt.text = data.trangthai;
        Debug.Log($"{data.trangthai}");

    }
    public void OnStatusButtonClick(int id)
    {
        //trangthai_btn_txt.text = "da nhan";
        

        Debug.Log($"vua chay ham OnStatusButtonClick voi text: {trangthai_btn_txt.text}");
        //foreach (var data in Data_bace_Quest.DatabaseScripts)
        //{
        //    if (data.id == id)
        //    {
        //        data.trangthai = "da nhan";
        //        data.trangthai_bl = false;
        //        trangthai_btn_txt.text = data.trangthai;
        //        Debug.Log($"sau khi tuc hien ham OnStatusButtonClick: {data.trangthai}");
        //    }

        //}

    }
}


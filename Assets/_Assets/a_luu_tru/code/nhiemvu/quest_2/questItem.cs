using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questItem : MonoBehaviour
{
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
        if (data == null)
        {
            Debug.LogWarning("Nh?n d? li?u data_Quest l� null.");
            return;
        }

        // G�n c�c thu?c t�nh t? data_Quest v�o c�c th�nh ph?n UI
        icon_img.sprite = data.anh_img;
        thongtin_txtt.text = data.thongtin_txt;
        tiendo_thucte_txt.text = data.tiendo_txt_thucte;
        tiendo_ht_txt.text = data.tiendo_txt_hoanthanh;

        // C?p nh?t Image tiendo n?u c?n, v� d?:
        

        // C?p nh?t tr?ng th�i n�t n?u c?n
        trangthai_btn.interactable = data.trangthai_bl;
        trangthai_btn_txt.text = data.trangthai; // N?u data.trangthai l� m?t Text, l?y n?i dung c?a n�
    }
}


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
    //public Image tiendo_img;
    //public Button trangthai_btn;
    //public Text trangthai_btn_txt;

    internal void SetData(data_Quest dataQuest/*, Quest_Savedata quest_Savedata*/)
    {
        this.Data_Quest = dataQuest;
        //this.quest_Savedata = quest_Savedata;
        //UpdateUI();
    }

   
    //public void UpdateUI()
    //{

    //    tiendo_thucte_txt.text = Data_Quest.tiendo_txt_thucte;
    //    trangthai_btn_txt.text = Data_Quest.trangthai;
    //    trangthai_btn.interactable = Data_Quest.trangthai_bl;

    //}

}

    


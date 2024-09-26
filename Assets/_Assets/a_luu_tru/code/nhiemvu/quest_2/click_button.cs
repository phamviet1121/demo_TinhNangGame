using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_button : MonoBehaviour
{

    //public Button button;
    //public Text test_btn;
    public data_bace_Quest Data_bace_Quest;

   
    public Button trangthai_btn;
    public Text trangthai_btn_txt;
    // Start is called before the first frame update
    public Dictionary<string, string> trangthai_btn_dict;
    void Start()
    {
        trangthai_nhiemvu();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void trangthai_nhiemvu()
    {
        foreach(var data in Data_bace_Quest.DatabaseScripts)
        {
            if(data.tiendo_txt_thucte==data.tiendo_txt_hoanthanh)
            {
                data.trangthai_bl = true;
                trangthai_btn.interactable = data.trangthai_bl;
                data.trangthai = "da hoan thanh roi do";
                trangthai_btn_txt.text = data.trangthai;
                trangthai_btn.onClick.AddListener(OnStatusButtonClick);
            }
        }
    }
    public void OnStatusButtonClick()
    {       
        trangthai_btn_txt.text = "da nhan";
    }


} 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dailyQuestItemHandler : MonoBehaviour
{
    public QuestDataa questDataa;
    public QuestProgress questProgress;


    public Image icomHandler;
    public Text thongtin_text;
    public Text tiendo_text;
    public Button trangthai_button;
    public Text trangthai_button_text;


    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetData(QuestDataa questDataa, QuestProgress questProgress)
    {
        this.questDataa = questDataa;
        this.questProgress = questProgress;
        updateUI();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateUI()
    {
        icomHandler.sprite = questDataa.anh_img;
        thongtin_text.text = questDataa.thongtin_txt;
        tiendo_text.text = questDataa.tendo_txt;
            trangthai_button.interactable = questDataa.trangthai_btn;
        trangthai_button_text.text = questDataa.trangthai_btn_txt;


    }

}

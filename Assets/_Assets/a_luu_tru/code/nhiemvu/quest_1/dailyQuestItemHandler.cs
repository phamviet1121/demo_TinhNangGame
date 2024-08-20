using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dailyQuestItemHandler : MonoBehaviour
{
    public QuestDataa questDataa;
    public QuestProgress questProgress;

    public Text dessriptionHandler;
    public Image icomHandler;
    public Text taskCoinHandler;
    public Text completeTaskHandler;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetData(QuestDataa questDataa, QuestProgress questProgress)
    {
        this.questDataa = questDataa;
        this.questProgress = questProgress;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateUI()
    {
        dessriptionHandler.text = questDataa.thongtin_txt;
        icomHandler.sprite = questDataa.anh_img;
        completeTaskHandler.text = questDataa.tiendo_txt;
        taskCoinHandler.text=questProgress.progresss;
    }
}

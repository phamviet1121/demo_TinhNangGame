using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Save_Quest;

public class DailyQuestManager : MonoBehaviour
{
    public questDatabace QuestDatabace;
    public dailyQuestItemHandler DailyQuestItemHandler;
    public Transform rootContentOnUI;
    public QuestProgressData questProgressData;
    public List<QuestProgress> qquestProgressList = new List<QuestProgress>(); // Đã sửa lỗi khai báo danh sách.

    // Start is called before the first frame update
    void Start()
    {
        LoadAll(); // Sửa lại thành LoadAll để tải dữ liệu.
        foreach (var questFrom in QuestDatabace.DatabaseList)
        {
            QuestProgress idProgress = questProgressData.questProgress.Find(idProgress => idProgress.id == questFrom.id);
            CreatQuest(questFrom, idProgress);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreatQuest(QuestDataa questDataa, QuestProgress questProgress)
    {
        var quest = Instantiate(DailyQuestItemHandler, rootContentOnUI);
        quest.SetData(questDataa, questProgress);
    }

    [ContextMenu("SaveAll")]
    public void SaveAll()
    {
        Debug.Log("da luu");
        qquestProgressList.Clear();
        foreach (var quest in QuestDatabace.DatabaseList)
        {
            var questDataa = new QuestProgress
            {
                id = quest.id,
                icon_ing = quest.anh_img,
                information_txt = quest.thongtin_txt,
                progress_txt = quest.tendo_txt,
                status_btn = quest.trangthai_btn,
                status_btn_txt = quest.trangthai_btn_txt,
            };
            qquestProgressList.Add(questDataa);
        }
        

    string json = JsonUtility.ToJson(qquestProgressList);
        Debug.Log($"{json}");
        PlayerPrefs.SetString(nameof(qquestProgressList), json);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveAll();
    }

    [ContextMenu("LoadAll")]
    public void LoadAll()
    {
        string json = PlayerPrefs.GetString(nameof(qquestProgressList), "{}");
        questProgressData = JsonUtility.FromJson<QuestProgressData>(json);

        QuestDatabace.DatabaseList.Clear();
        foreach (var savedData in qquestProgressList)
        {
            var quest = new QuestDataa
            {
                id = savedData.id,
                anh_img = savedData.icon_ing,
                thongtin_txt = savedData.information_txt,
                tendo_txt = savedData.progress_txt,
                trangthai_btn = savedData.status_btn,
                trangthai_btn_txt = savedData.status_btn_txt,
            };
            QuestDatabace.DatabaseList.Add(quest);
        }
    }
}

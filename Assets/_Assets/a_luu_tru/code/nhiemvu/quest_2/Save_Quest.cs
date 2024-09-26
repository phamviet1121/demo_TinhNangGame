using System;
using System.Collections.Generic;
using UnityEngine;

public class Save_Quest : MonoBehaviour
{
    [SerializeField]
    private  data_bace_Quest Data_Bace_Quest;
    [SerializeField]
    public List<Quest_Savedata> quest_SavedataList = new List<Quest_Savedata>();

    void Start()
    {
        LoadAll();
    }


    [ContextMenu("SaveAll")]
    public void SaveAll()
    {
        // Chuy?n ??i d? li?u quest thành Quest_Savedata
        quest_SavedataList.Clear();
        foreach (var quest in Data_Bace_Quest.DatabaseScripts)
        {
            var savedData = new Quest_Savedata
            {
                id = quest.id, 
                anh_img = quest.anh_img, 
                thongtin_txt = quest.thongtin_txt,
                tiendo_txt_thucte = quest.tiendo_txt_thucte,
                tiendo_txt_hoanthanh = quest.tiendo_txt_hoanthanh,
                trangthai_bl = quest.trangthai_bl,
                trangthai = quest.trangthai
            };
            quest_SavedataList.Add(savedData);
        }

        // Chuy?n ??i danh sách thành JSON và l?u
        string json = JsonUtility.ToJson(new SaveQuestDataList { ListString = quest_SavedataList });
        PlayerPrefs.SetString("quest_SavedataList", json);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveAll();
    }

    [ContextMenu("LoadAll")]
    public void LoadAll()
    {
        string json = PlayerPrefs.GetString("quest_SavedataList", "{}");
        SaveQuestDataList loadedData = JsonUtility.FromJson<SaveQuestDataList>(json);

        if (loadedData != null && loadedData.ListString != null)
        {
            quest_SavedataList = loadedData.ListString;

          
            Data_Bace_Quest.DatabaseScripts.Clear();
            foreach (var savedData in quest_SavedataList)
            {
                var quest = new data_Quest
                {
                    id = savedData.id, // C?n có thu?c tính id trong data_Quest
                    anh_img = savedData.anh_img, // C?n chuy?n ??i ng??c t? ??nh d?ng có th? serialize
                    thongtin_txt = savedData.thongtin_txt,
                    tiendo_txt_thucte = savedData.tiendo_txt_thucte,
                    tiendo_txt_hoanthanh = savedData.tiendo_txt_hoanthanh,
                    trangthai_bl = savedData.trangthai_bl,
                   trangthai = savedData.trangthai // N?u tr?ng thái là chu?i, n?u không c?n s?a cho phù h?p
                };
                Data_Bace_Quest.DatabaseScripts.Add(quest);
            }
        }
    }

    [Serializable]
    public class SaveQuestDataList
    {
        public List<Quest_Savedata> ListString;
    }












}

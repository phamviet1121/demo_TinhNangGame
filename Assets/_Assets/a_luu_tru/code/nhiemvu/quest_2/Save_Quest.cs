using System;
using System.Collections.Generic;
using UnityEngine;

public class Save_Quest : MonoBehaviour
{
    [SerializeField]
    private data_bace_Quest Data_Bace_Quest;

    private List<Quest_Savedata> quest_SavedataList = new List<Quest_Savedata>();

    void Start()
    {
        // Có th? thêm logic kh?i t?o ? ?ây n?u c?n
    }

    // N?u b?n mu?n c?p nh?t quest_SavedataList khi d? li?u quest thay ??i, b?n c?n thêm logic.
    // B?n có th? s? d?ng m?t ph??ng th?c khác ?? g?i c?p nh?t d? li?u khi c?n thi?t.

    [ContextMenu("SaveAll")]
    private void SaveAll()
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
                trangthai_btn_txt.text = quest.trangthai 
            };
            quest_SavedataList.Add(savedData);
        }

        // Chuy?n ??i danh sách thành JSON và l?u
        string json = JsonUtility.ToJson(new SaveQuestDataList { ListString = quest_SavedataList });
        PlayerPrefs.SetString("quest_SavedataList", json);
        PlayerPrefs.Save();
    }

    [ContextMenu("LoadAll")]
    private void LoadAll()
    {
        string json = PlayerPrefs.GetString("quest_SavedataList", "{}");
        SaveQuestDataList loadedData = JsonUtility.FromJson<SaveQuestDataList>(json);

        if (loadedData != null && loadedData.ListString != null)
        {
            quest_SavedataList = loadedData.ListString;

            // C?p nh?t d? li?u trong Data_Bace_Quest n?u c?n
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
                    trangthai = savedData.trangthai_txt // N?u tr?ng thái là chu?i, n?u không c?n s?a cho phù h?p
                };
                Data_Bace_Quest.DatabaseScripts.Add(quest);
            }
        }
    }

    [Serializable]
    private class SaveQuestDataList
    {
        public List<Quest_Savedata> ListString;
    }
}

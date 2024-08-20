using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Quest : MonoBehaviour
{


    [SerializeField]
    public data_bace_Quest databaseScripts_1;
    public daliquestIntemHandler DaliquestIntemHandler;
    public Transform rootUI;
    public questItem QuestItem;


    private void Start()
    {

        foreach (var questdata in databaseScripts_1.DatabaseScripts)
        {
        //    Quest_Savedata questSavedata = Save_Quest.quest_SavedataList.Find(quest_SavedataList);
            CreatQuest(questdata);
            QuestItem.Setdata(questdata);

        }
    }
    void Update()
    {
        //foreach (var questdata in databaseScripts_1.DatabaseScripts)
        //{
            
        //    QuestItem.Setdata(questdata);

        //}
    }

    private void CreatQuest(data_Quest Data_Questt /*, Quest_Savedata quest_Savedata*/)
    {
        var quest = Instantiate(DaliquestIntemHandler, rootUI);
        quest.SetData(Data_Questt /*, quest_Savedata*/);
    }
}

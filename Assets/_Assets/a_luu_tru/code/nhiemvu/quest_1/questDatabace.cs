using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "DataList", menuName = "ScriptableObjects/Quests", order = 1)]
public class questDatabace : ScriptableObject
{
    //List<QuestDataa> databaceList;
    [SerializeField]
    public List<QuestDataa> DatabaseList;
}


[SerializeField]
public class QuestProgress
{
    public int id;
    public Sprite icon_ing;
    public string information_txt;
    public string progress_txt;
    public bool status_btn;
    public string status_btn_txt;



}
[SerializeField]
public class QuestProgressData
{
    public List<QuestProgress> questProgress;
}


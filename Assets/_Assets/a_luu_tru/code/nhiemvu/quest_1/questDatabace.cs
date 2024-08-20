using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public string progresss;
    public bool isComleted;

}
public class QuestProgressData
{
    public List<QuestProgress> questProgress;
}


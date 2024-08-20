using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyQuestManager : MonoBehaviour
{
    public questDatabace QuestDatabace;
    public dailyQuestItemHandler DailyQuestItemHandler;
    public Transform rootContentOnUI;
    public QuestProgressData questProgressData;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var questFrom in QuestDatabace.DatabaseList)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

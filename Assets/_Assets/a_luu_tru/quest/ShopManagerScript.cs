using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManagerScript : MonoBehaviour
{
    public int[,] ShopItems = new int[5, 5];
    public float coins;
    public Text Conis_txt;
    void Start()
    {
        Conis_txt.text = "coins:" + coins.ToString();

        ShopItems[1, 1] = 1;
        ShopItems[1, 2] = 2;
        ShopItems[1, 3] = 3;
        ShopItems[1, 4] = 4;

        ShopItems[2, 1] = 10;
        ShopItems[2, 2] = 20;
        ShopItems[2, 3] = 30;
        ShopItems[2, 4] = 40;

        ShopItems[3, 1] = 0;
        ShopItems[3, 2] = 0;
        ShopItems[3, 3] = 0;
        ShopItems[3, 4] = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buy()
    {
        GameObject ButtonRef= GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= ShopItems[2, ButtonRef.GetComponent<ButtonInfor>().ItemID])
        {
            coins-= ShopItems[2, ButtonRef.GetComponent<ButtonInfor>().ItemID];
            ShopItems[3, ButtonRef.GetComponent<ButtonInfor>().ItemID]++;
            ButtonRef.GetComponent<ButtonInfor>().Quantity_txt.text= ShopItems[3, ButtonRef.GetComponent<ButtonInfor>().ItemID].ToString();








        }

    }
}

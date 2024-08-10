using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonInfor : MonoBehaviour
{
    public int ItemID;
    public Text Pirce_txt;
    public Text Quantity_txt;
    public GameObject ShopManager;





    void Start()
    {
        Pirce_txt.text= "Pirce:$"+ ShopManager.GetComponent<ShopManagerScript>().ShopItems[2,ItemID].ToString();
        Quantity_txt.text = ShopManager.GetComponent<ShopManagerScript>().ShopItems[3, ItemID].ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tạo_ra_gameobject : MonoBehaviour
{
    public GameObject ICON_GIAP;
    public GameObject NEW_ICON_GIAP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Time.time;
       if (a % 50 == 0)
        {
            taora();
        }
          

    }
    public void taora()
    {
        float a = Random.Range(Random.Range(-10, -15), Random.Range(10, 15));
        float b = Random.Range(Random.Range(-10, -15), Random.Range(10, 15));
        Vector2 vitrino = new Vector2(transform.position.x + a, transform.position.y + b);
        //Destroy(gameObject);
        NEW_ICON_GIAP = Instantiate(ICON_GIAP, vitrino, Quaternion.identity);
    }    



}

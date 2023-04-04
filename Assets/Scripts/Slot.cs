using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
   
    public Items apg;



    public void UpdateSlot()
    {
        
        this.GetComponent<Image>().sprite = apg.icon;

    }


}

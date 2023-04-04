using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Items 
{

    public int ID;

    public string type;

    public string description;

    public Sprite icon;

    public int cantidad;

    [HideInInspector]
    public bool pickedUp;

}

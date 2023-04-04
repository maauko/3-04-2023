using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private bool inventoryEnabled;

    public GameObject inventory;

    private int allslot;

    private int enableslot;

    private Slot[] slot;

    public GameObject slotHolder;


    public GameObject Tienda;

    public GameObject SlothonderTienda;

    public KeyCode inventarioTeclado;

  


    // Start is called before the first frame update
    void Start()
    {



        allslot = slotHolder.transform.childCount;

        slot = slotHolder.GetComponentsInChildren<Slot>();

       

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(inventarioTeclado)) {inventoryEnabled = !inventoryEnabled;}
        if (inventoryEnabled)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }



       
    }


}

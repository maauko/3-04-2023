using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Tienda : MonoBehaviour
{
    private bool TiendaEnabled;

    public GameObject inventory;

    private int allslot;

    private int enableslot;

    private Slot[] slot;


    public GameObject slotHolder;

    public KeyCode TiendaTeclado;

    public List<Items> ListaArma;

    public UnityEvent<Slot> Voyaver;



    // Start is called before the first frame update
    void Start()
    {
        allslot = slotHolder.transform.childCount;

        slot = slotHolder.GetComponentsInChildren<Slot>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(TiendaTeclado))
        {
            TiendaEnabled = !TiendaEnabled;
        }
        if (TiendaEnabled)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }

    public void Showitem(Slot slotss)
    {

        Debug.Log(slotss.apg.description);

    }

    public void BuyItem(Slot slotss)

    {
        Debug.Log("Compraste: "+slotss.apg.type);

        Voyaver.Invoke(slotss);

    }

    public void saveItem(Slot item)
    {

        if (ListaArma.Contains(item.apg))
        {
            Debug.Log("se añadio item existente");
            int i = ListaArma.FindIndex(x => x.ID == item.apg.ID); 
            ListaArma[i].cantidad += 1;
        }
        else
        {
            Debug.Log("se añadio un nuevo item");
            ListaArma.Add(item.apg);   
            
        }

    }

}

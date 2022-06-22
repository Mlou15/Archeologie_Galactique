using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseExit : MonoBehaviour
{
   
    public TMP_Text tm;
    public bool isMouseOver = false;
    
    private void OnMouseOver()
    {
       isMouseOver = true; // La souris passe ou pas sur la carte
    }

    private void OnMouseExit()
    {
        isMouseOver=false;
    }
    
}



public enum Planete
{
    Planete_A,
    Planete_B,
    Planete_C,
    Planete_D,
    Planete_E,
    Planete_F,
    Planete_G,
    Planete_H,
    Planete_I,
    
}
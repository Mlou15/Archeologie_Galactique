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
    Kappa,
    andromedae,
    Trappist,
    Luytenb,
    SagittarusA,
    Kepler,
    Proxima_Centauri,
    Eridani,
    Barnard,
    dodo,
    pause_caf�,
    plan�te_X,
    Magellan,
    C�r�s,
    Mak�mak�,
    Messier,
    tucanae,
    PetiteOurs,
    TauCeti,
    wasp,



}
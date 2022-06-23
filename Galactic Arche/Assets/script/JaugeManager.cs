using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class JaugeManager : MonoBehaviour
{
    public TinderSwap gm;
    public GameObject carte;

    public Image jaugeRecherche;
    public Image JaugeErreur;
    public Image JaugeTemps;

    public Image DJaugeRecherche;
    public Image DJaugeErreur;
    public Image DJaugeTemps;

      
    private void Update()
    {
        JaugeErreur.fillAmount = (float)TinderSwap.JaugeErreur / TinderSwap.ValeurMax;
        jaugeRecherche.fillAmount = (float)TinderSwap.jaugeRecherche / TinderSwap.ValeurMax;
        JaugeTemps.fillAmount = (float)TinderSwap.JaugeTemps / TinderSwap.ValeurMax;



        if (gm.direction == "droite") //Vers la droite
        {
            if(gm.CarteActu.Drecherche!=0)
            DJaugeRecherche.transform.localScale = new Vector3(1, 1, 0);
            if(gm.CarteActu.Derreur!=0)
            DJaugeErreur.transform.localScale = new Vector3(1, 1, 0);
            if (gm.CarteActu.DTemps != 0)
            DJaugeTemps.transform.localScale = new Vector3(1, 1, 0);
        }
    
        else if (gm.direction == "gauche")//Vers la gauche
        {
            if (gm.CarteActu.Grecherche != 0)
                DJaugeRecherche.transform.localScale = new Vector3(1, 1, 0);
            if (gm.CarteActu.Gerreur != 0)
                DJaugeErreur.transform.localScale = new Vector3(1, 1, 0);
            if (gm.CarteActu.GTemps != 0)
                DJaugeTemps.transform.localScale = new Vector3(1, 1, 0);
        }
        else
        {
            DJaugeRecherche.transform.localScale = new Vector3(0,0,0);
            DJaugeErreur.transform.localScale = new Vector3(0,0,0);
            DJaugeTemps.transform.localScale = new Vector3(0,0,0);
}
     

    }
}

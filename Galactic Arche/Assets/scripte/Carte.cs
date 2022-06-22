using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] //Création de la classe carte dans le menu 
    public class Carte : ScriptableObject
    {
        
        public int carteID;
        public string NomCarte;
        public Planete sprite;
        public string DialogueGauche;
        public string DialogueDroite;
    [Multiline]
    public string Info;

    public int Grecherche;
    public int Gerreur;

    public int Drecherche;
    public int Derreur;


        public void VersGauche()
        {
        TinderSwap.JaugeErreur += Gerreur;
        TinderSwap.jaugeRecherche += Grecherche;

        }
        public void VersDroit()
        {
        TinderSwap.JaugeErreur += Derreur;
        TinderSwap.jaugeRecherche += Drecherche;

        }

    }


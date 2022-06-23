using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TinderSwap : MonoBehaviour
{
    public GameObject carte;
    public MouseExit Mouxit;
    public SpriteRenderer sr;
    
    public GestionPlanete GSPlanete;
    public float Valeur;
    public float SideMargin;
    public float SideTrigger;
    float MovingSpeed = 1f;
    //Texte
    public TMP_Text display;
    public TMP_Text dialogue;
    public TMP_Text InfoCarte;
    //couleur + Affichage gauche droite
    public string direction;
    float alphaText;
    Color ColorTxt;
    public Color Cback;
    private string Vgauche;
    private string Vdroite;

    public  Carte CarteActu;
    //Jauge 
    public static int jaugeRecherche;
    public static int JaugeErreur;
    public static int JaugeTemps;
    public static int ValeurMax=100;
    public static int ValeurMin=0;
    
    


     void Start()
    {
        ChargeCarte(CarteActu);
    }

    void FinduJeu()
    {
        if (jaugeRecherche >= ValeurMax)
        {
            Debug.Log("Gagner");
            SceneManager.LoadScene(4);
        }
        else if(JaugeErreur >= ValeurMax)
        {
            Debug.Log("Perdre");
            SceneManager.LoadScene(5);
        }
        else if(JaugeTemps >= ValeurMax)
        {
            SceneManager.LoadScene(5);
        }
    }
    void ChargementDialogue()
    {
        dialogue.color = ColorTxt;
        if (carte.transform.position.x < 0)
        {
            
            
            dialogue.text = Vgauche;
        }
        else
        {
            dialogue.text = Vdroite;
        }
    }
    void Update()
    {

        Debug.Log(JaugeErreur);

        //Gestion de l'affichage du texte de la carte
        //Vérification gauche et droite
        ColorTxt.a = Mathf.Min(Mathf.Abs(carte.transform.position.x) -SideMargin/Valeur, 1);
        
        if (carte.transform.position.x > SideTrigger)
        {
            direction = "droite";

            if (Input.GetMouseButtonUp(0))
            {
                CarteActu.VersDroit();
                ChangementCarte();
            }

        }
        else if(carte.transform.position.x > SideMargin)
        {
            direction = "droite";

        }
        else if(carte.transform.position.x > -SideMargin)
        {
            direction = "none";
            ColorTxt.a = 0;
            
        }
        else if (carte.transform.position.x > -SideTrigger)
        {
            direction = "gauche";
        }
        else
        {
            direction = "gauche";

            if (Input.GetMouseButtonUp(0))
            {
                CarteActu.VersGauche();
                ChangementCarte();
            }
        }
        ChargementDialogue();
        FinduJeu();



        if (Input.GetMouseButton(0)&&Mouxit.isMouseOver) //Mouvement de la carte avec la touche gauche de la souris
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Prendre la position de la souris
            carte.transform.position = pos;
        }
        else
        {
            carte.transform.position = Vector2.MoveTowards(carte.transform.position, new Vector2(0, 1), MovingSpeed); //La carte reprend sa place initiale
        }

        display.text = "" + alphaText;
    }
    public void ChargeCarte(Carte carte) //récup et charger les différentes planètes
    {
        sr.sprite = GSPlanete.Splanetes[(int)carte.sprite]; //load les sprites

        Vgauche = carte.DialogueGauche;
        Vdroite = carte.DialogueDroite;
        CarteActu = carte;
        InfoCarte.text = carte.Info;

    }
    int randomNumber;
    int lastNumber;
    int maxTry = 20;
    public void ChangementCarte()
    {
       for(int i=0;randomNumber == lastNumber && i<maxTry; i++)
        {
            randomNumber = Random.Range(0, GSPlanete.Cartes.Length);
        }
         lastNumber = randomNumber;
        

        ChargeCarte(GSPlanete.Cartes[randomNumber]);
        
        
      
    
    }
    


}




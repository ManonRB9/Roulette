using System;
using UnityEngine.UI;
using UnityEngine;

public class Mwheel : MonoBehaviour
{

    private string[] wheelSymbol = // on crée le tableau des liens des sprites
        {
            "Graphique/Lpointx1", "Graphique/Lpointx2", "Graphique/Rpointx1", "Graphique/Rpointx2", "Graphique/nothing", "Graphique/Wall"
        };

    //private Sprite symbolSprite; //not use for the moment 

    private int[] wheelCounts; //on crée un tableau de compteur pour les cinq roulettes

    private Sprite[] rollSprites;//on crée un tableau de sprite qui correspond a toutes les images qui vont dans la roulette

    public UnityEngine.UI.Image[] imageSymbols; // on crée un tableau d'image pour récupérer les images depuis unity 

    private bool[] RollsBlocked;

    
    void Start()
    {   
        //on instantie les tableaux
        rollSprites = new Sprite[wheelSymbol.Length];
        wheelCounts = new int [5];
        RollsBlocked = new bool[5];
        
        //on remplie les tableaux
        int i = 0;
        foreach(string name in wheelSymbol)
        {
            rollSprites[i] = Resources.Load<Sprite>(wheelSymbol[i]); //on charge les sprites pour chaque i
            i++;
        }
        for (i = 0; i < 5; i++) 
        {
            wheelCounts[i]=0; // chaque compteur de roue vos 0
            RollsBlocked[i] = false; // toutes no roue ne sont pas bloquées
        }
    }

    void Update()
    {   
        //on transphère les images à Unity 
        for(int i = 0; i<5; i++) imageSymbols[i].sprite = rollSprites[wheelCounts[i]]; //rollSprites = nombre de sprite, et on vient chercher les sprite qui correspond au compteur de la roue
    }
    public void RollButtonPressed()
    {   
        //Chaque compteurs prends une valeur aléatoire
        System.Random rand = new System.Random();
        for(int i = 0; i<5; i++)
        {
            if (!RollsBlocked[i])
            {
                wheelCounts[i] = rand.Next(wheelSymbol.Length);
            }          
        }
    }
    public void Roll1ButtonPressed()
    {   
       RollsBlocked[0] = !RollsBlocked[0]; 
    }

    public void Roll2ButtonPressed()
    {   
       RollsBlocked[1] = !RollsBlocked[1]; 
    }

    public void Roll3ButtonPressed()
    {   
       RollsBlocked[2] = !RollsBlocked[2]; 
    }

    public void Roll4ButtonPressed()
    {   
       RollsBlocked[3] = !RollsBlocked[3]; 
    }

    public void Roll5ButtonPressed()
    {   
       RollsBlocked[4] = !RollsBlocked[4]; 
    }
      
      

}

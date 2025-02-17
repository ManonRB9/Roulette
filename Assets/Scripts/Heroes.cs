using UnityEngine;

public class Heroes
{
    public string heroesName;

    public int mentalValue;  

    public int strenghValue;

    public int luckValue;

    public string imageFileName;

    public string specialAttack;

    public Heroes(string name)//ceci est un constructeur 
    {
        switch(name)
        {
            case "Teranis" : 
                mentalValue = 19;
                strenghValue = 2;
                luckValue = 20;
                imageFileName = "Graphique/Teranis";
                specialAttack = "Speak of truth";
                break;

            case "Azera" : 
                mentalValue = 10;
                strenghValue = 18;
                luckValue = 12;
                imageFileName = "Graphique/Azera";
                specialAttack = "PowerAttack";
                break;
                
            case "Araminth" : 
                mentalValue = 15;
                strenghValue = 15;
                luckValue = 9;
                imageFileName = "Graphique/Araminth";
                specialAttack = "through the wall";
                break;

            default : 
                mentalValue = 19;
                strenghValue = 2;
                luckValue = 20;
                imageFileName = "Graphique/Teranis";
                specialAttack = "Speak of truth";
                break;

        }

        heroesName = name;
    }

    
}

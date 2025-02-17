using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;

public class HeroesPanel : MonoBehaviour
{
    public Heroes[] allHeroes;
    public string[] gameHeroes = {"Teranis", "Azera", "Araminth"};

    private int maxHeroes;

    private int heroesCount;

    public TextMeshProUGUI nameTxt, mentalTxt, strenghTxt, luckTxt, spacialAtkTxt;

    public UnityEngine.UI.Image imageHeroes;

    private Sprite heroesSprite;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHeroes = gameHeroes.Length; // on récupère la longueur du tableau donc les trois valeurs
        allHeroes = new Heroes[maxHeroes];
        maxHeroes -= 1;
        int i = 0;
        foreach (string name in gameHeroes)
        {
            allHeroes[i] = new Heroes(name);
            i++;
        }

        heroesCount = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        nameTxt.text =allHeroes[heroesCount].heroesName;
        mentalTxt.text =allHeroes[heroesCount].mentalValue.ToString();
        strenghTxt.text=allHeroes[heroesCount].strenghValue.ToString(); 
        luckTxt.text =allHeroes[heroesCount].luckValue.ToString();
        spacialAtkTxt.text =allHeroes[heroesCount].specialAttack;
        heroesSprite = Resources.Load<Sprite>(allHeroes[heroesCount].imageFileName); //je viens cherger le sprite du héros
        imageHeroes.sprite = heroesSprite; // j'attribue le sprite a l'image du héros
    }


    public void NextBtnPressed()
    {
        heroesCount +=1; // c'est pour passer au héroes suivant 

        if(heroesCount > maxHeroes)
        {
            heroesCount = 0;
        }
    }

    public void PrevBtnPressed()
    {
        heroesCount--; // c'est pour passer au héroes précédant 

        if(heroesCount < 0)
        {
            heroesCount = maxHeroes;
        }
    }
}

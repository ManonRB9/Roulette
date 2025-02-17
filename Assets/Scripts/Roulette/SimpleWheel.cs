using UnityEngine;

public class SimpleWheel
{
    
    public string symbolName;
    public string imageFileName;

    public SimpleWheel(string form)
    {
        switch (form)
        {
            case "LPointx1" :
                imageFileName ="Graphique/Lpointx1";
                break;
            case "LPointx2" :
                imageFileName = "Graphique/Lpointx2";
                break;
            case "RPointx1" :
                imageFileName = "Graphique/Rpointx1";
                break;
            case "RPointx2" :
                imageFileName = "Graphique/Rpointx2";
                break;
            case "Nothing" :
                imageFileName = "Graphique/nothing";
                break;
            case "Wall" :
                imageFileName = "Graphique/Wall";
                break;
        }
        

        symbolName = form;
    }
}

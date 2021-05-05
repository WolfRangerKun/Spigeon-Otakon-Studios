using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomManager : MonoBehaviour
{
    public SpriteRenderer theSprite;
    public List<Sprite> estados;
    public enum MATERIAL_CLASE
    {
        CEROMATERIAL,
        UNMATERIAL,
        DOSMATERIAL,
        TRESMATERIAL,
        CUATROSMATERIAL

    }
    public MATERIAL_CLASE materialClase;

    public void ChangeClass(MATERIAL_CLASE nuevaClase)
    {

        switch (nuevaClase)
        {
            case MATERIAL_CLASE.CEROMATERIAL:
                theSprite.sprite = estados[0];
                break;
            case MATERIAL_CLASE.UNMATERIAL:
                theSprite.sprite = estados[1];
                break;
            case MATERIAL_CLASE.DOSMATERIAL:
                theSprite.sprite = estados[2];
                break;
            case MATERIAL_CLASE.TRESMATERIAL:
                theSprite.sprite = estados[3];
                break;
            case MATERIAL_CLASE.CUATROSMATERIAL:
                theSprite.sprite = estados[4];
                break;
        }
    }
}

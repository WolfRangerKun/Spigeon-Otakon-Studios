using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtomManager : MonoBehaviour
{
    public Button theButton;
    public List<Sprite> estado;
    public GridBuildingSystem2D grid;
    
    public enum MATERIAL_CLASE
    {
        CEROMATERIAL,
        UNMATERIAL,
        DOSMATERIAL,
        TRESMATERIAL,
        CUATROSMATERIAL

    }
    public MATERIAL_CLASE materialClase;

    public void ChangeButtomImage(MATERIAL_CLASE nuevaClase)
    {
        materialClase = nuevaClase;
        switch (nuevaClase)
        {
            case MATERIAL_CLASE.CEROMATERIAL:
                theButton.image.sprite = estado[0];
                break;
            case MATERIAL_CLASE.UNMATERIAL:
                theButton.image.sprite = estado[1];
                break;
            case MATERIAL_CLASE.DOSMATERIAL:
                theButton.image.sprite = estado[2];
                break;
            case MATERIAL_CLASE.TRESMATERIAL:
                theButton.image.sprite = estado[3];
                break;
            case MATERIAL_CLASE.CUATROSMATERIAL:
                theButton.image.sprite = estado[4];
                break;
        }
    }

    private void FixedUpdate()
    {
        if(grid.limitPlatforms == 0)
        {
            ChangeButtomImage(MATERIAL_CLASE.CEROMATERIAL);
        }

        if (grid.limitPlatforms == 1)
        {
            ChangeButtomImage(MATERIAL_CLASE.UNMATERIAL);
        }

        if (grid.limitPlatforms == 2)
        {
            ChangeButtomImage(MATERIAL_CLASE.DOSMATERIAL);
        }

        if (grid.limitPlatforms == 3)
        {
            ChangeButtomImage(MATERIAL_CLASE.TRESMATERIAL);
        }

        if (grid.limitPlatforms == 4)
        {
            ChangeButtomImage(MATERIAL_CLASE.CUATROSMATERIAL);
        }
    }
}

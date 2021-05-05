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
    public void PlatformImageButtom()
    {
        if (grid.limitPlatforms == 0)
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

    private void FixedUpdate()
    {
        PlatformImageButtom();
        AmmoImageChange();
    }


    public void AmmoImageChange()
    {
        if (shoot.ammo == 0)
        {
            ChangeAmmoImage(MATERIAL_BALAS.CEROBALAS);
        }

        if (shoot.ammo == 1)
        {
            ChangeAmmoImage(MATERIAL_BALAS.UNABALAS);

        }

        if (shoot.ammo == 2)
        {
            ChangeAmmoImage(MATERIAL_BALAS.DOSBALAS);

        }

        if (shoot.ammo == 3)
        {
            ChangeAmmoImage(MATERIAL_BALAS.TRESBALAS);

        }

        if (shoot.ammo == 4)
        {
            ChangeAmmoImage(MATERIAL_BALAS.CUATROBALAS);

        }

        if (shoot.ammo == 5)
        {
            ChangeAmmoImage(MATERIAL_BALAS.CINCOBALAS);

        }

        if (shoot.ammo == 6)
        {
            ChangeAmmoImage(MATERIAL_BALAS.SEISBALAS);

        }

        if (shoot.ammo == 7)
        {
            ChangeAmmoImage(MATERIAL_BALAS.SIETEBALAS);

        }

        if (shoot.ammo == 8)
        {
            ChangeAmmoImage(MATERIAL_BALAS.OCHOBALAS);

        }
    }

    public Image theImage;
    public List<Sprite> ammo;

    public Shoot2 shoot;
    public enum MATERIAL_BALAS
    {
        CEROBALAS,
        UNABALAS,
        DOSBALAS,
        TRESBALAS,
        CUATROBALAS,
        CINCOBALAS,
        SEISBALAS,
        SIETEBALAS,
        OCHOBALAS,

    }
    public MATERIAL_BALAS materialBalas;

    public void ChangeAmmoImage(MATERIAL_BALAS nuevaAmmo)
    {
        materialBalas = nuevaAmmo;
        switch (nuevaAmmo)
        {
            case MATERIAL_BALAS.CEROBALAS:
                theImage.sprite = ammo[0];
                break;
            case MATERIAL_BALAS.UNABALAS:
                theImage.sprite = ammo[1];
                break;
            case MATERIAL_BALAS.DOSBALAS:
                theImage.sprite = ammo[1];
                break;
            case MATERIAL_BALAS.TRESBALAS:
                theImage.sprite = ammo[3];
                break;
            case MATERIAL_BALAS.CUATROBALAS:
                theImage.sprite = ammo[4];
                break;
            case MATERIAL_BALAS.CINCOBALAS:
                theImage.sprite = ammo[5];
                break;
            case MATERIAL_BALAS.SEISBALAS:
                theImage.sprite = ammo[6];
                break;
            case MATERIAL_BALAS.SIETEBALAS:
                theImage.sprite = ammo[7];
                break;
            case MATERIAL_BALAS.OCHOBALAS:
                theImage.sprite = ammo[8];
                break;

        }
    }
}

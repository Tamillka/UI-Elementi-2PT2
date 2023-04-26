using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {

	public GameObject beensImg;
	public GameObject lacisImg;
    public GameObject masinaImg;
    public GameObject tanteImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject izmSlaideris;
    public GameObject rotSlaideris;

    public void binaAttelosana(bool vertiba) {
        beensImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }
    public void lacisAttelosana(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }
    public void masinaAttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }
    public void tanteAttelosana(bool vertiba)
    {
        tanteImg.SetActive(vertiba);
    }

    public void paKreisiBeens(bool vertiba) {
        beensImg.transform.localScale = new Vector2(1, 1);
    }
    public void paLabiBeens(bool vertiba) {
        beensImg.transform.localScale = new Vector2(-1, 1);
    }
    public void Izkritosais(int skaitlis) {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("Nav piesaistits attels!");
    }

    public void mainitLielumu() { 
        float pasreizejaVertiba = izmSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba);
    }
    public void mainitRotaciju() { 
        float pasreizejaVertiba = rotSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localRotation = Quaternion.Euler(0, 0, pasreizejaVertiba * 360);
    }
}

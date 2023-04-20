using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	public string teksts;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	private string[] fragmenti = { "Helloo ", "Good luck!", "Nahuja pripersja ", "Ljubvi, udachi, terpenija, POKA!" };
	int indekss;
	public void UzglabatTekstu() {
		indekss = Random.Range(0, fragmenti.Length);
		teksts = ievadesLauks.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text=
		fragmenti[indekss] + teksts.ToUpper() + "!";
	}


}

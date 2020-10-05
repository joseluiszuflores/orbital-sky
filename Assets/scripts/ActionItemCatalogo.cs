using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public static class ButtonExtension 
{
	public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick){
		button.onClick.AddListener(delegate(){
			OnClick(param);
		});
	}
}
public class ActionItemCatalogo : MonoBehaviour
{

	[Serializable]
	
	public struct Satelite
	{
		public string Nombre;
		public int ID;
		public string intlCode;
		public string Estatus;
		public string Categoria;
		
		public Satelite(string nombre, int id, string itlcode,string estatus, string Categoria){
			this.Nombre = nombre;
			this.ID = id;
			this.intlCode = itlcode;
			this.Estatus= estatus;
			this.Categoria = Categoria;
		}
	}


	 Satelite[] categorias= new Satelite[] {
		new Satelite("QUETZAL-1" ,45598,"1998-067RL","Active","Amateur radio"),	
		new Satelite("QARMAN" ,45263,"1998-067RG","Active","Amateur radio"),	
		new Satelite("RADSAT-U" ,45262,"1998-067RF","Inactive","Amateur radio"),	
		new Satelite("AZTECHSAT-1" ,45261,"1998-067RE","Active","Amateur radio"),
		new Satelite("GALAXY 30",	46114,"2020-056C","August 15, 2020","GEOSTATIONARY"),
		new Satelite("BEIDOU 3 G2",	45344,"2020-017A","March 9, 2020","GEOSTATIONARY"),
		new Satelite("GEO-KOMPSAT-2B",	45246,"2020-013B","February 18, 2020","GEOSTATIONARY"),
		new Satelite("JCSAT 17",	45245,"2020-013A","February 18, 2020","GEOSTATIONARY"),
		new Satelite("EUTELSAT KONNECT",	45027,"2020-005B","January 16, 2020","GEOSTATIONARY"),
		new Satelite("GSAT 30",	45026,"2020-005A","January 16, 2020","GEOSTATIONARY"),
		new Satelite("SJ-20",	44910,"2019-097A","December 27, 2019","GEOSTATIONARY"),
		new Satelite("INMARSAT GX5",	44801,"2019-080B","November 26, 2019","GEOSTATIONARY"),
	};
    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = this.transform.GetChild(0).gameObject;
		GameObject g;
		int total = categorias.Length;
		
		Debug.Log("totales: " + total);
		for (int i=0; i<total; i++) {
			g = Instantiate (buttonTemplate,transform);
			g.transform.GetChild(1).GetComponent<Text>().text = categorias[i].Nombre;
			g.transform.GetChild(2).GetComponent<Text>().text = categorias[i].Estatus;
			g.GetComponent<Button>().AddEventListener(i,itemClick);
		}
		Destroy(buttonTemplate);

    }
	void itemClick(int i) {
		Debug.Log("Satelite: " + i);
	}

}
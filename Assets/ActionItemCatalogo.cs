using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ActionItemCatalogo : MonoBehaviour
{

	[Serializable]
	public struct Categoria
	{
		public string Nombre;
		public Sprite Icon;
	}

	[SerializeField] Categoria[] categorias;
    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = this.transform.GetChild (0).gameObject;
		GameObject g;
		int total = categorias.Length;
		for (int i=0; i<total; i++) {
			g = Instantiate (buttonTemplate,transform);
			g.transform.GetChild(0).GetComponent<Image>().sprite = categorias[i].Icon;
			g.transform.GetChild(1).GetComponent<Text>().text = categorias[i].Nombre;
		}
		Destroy(buttonTemplate);

    }
}

using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Collections.Generic;

// Created by: Hamza Herbou        (mobile games developer)
// email     : hamza95herbou@gmail.com


[CustomEditor (typeof(GridViewPopup))]
public class GridViewPopupEditor : Editor
{
	private GridViewPopup grid;


	private RectTransform GridContent;
	private GameObject GridItemPrefab;

	public Sprite defIcon;

	private GameObject go;



	override public void OnInspectorGUI ()
	{
		grid = (GridViewPopup)target;
		GridContent = grid.GridContent;
		GridItemPrefab = grid.GridItemPrefab;

		defIcon = grid.defaultIcon;

		base.OnInspectorGUI ();

		if (GUILayout.Button ("Save Changes")) {
			Save ();
		}
	}


	public void Save ()
	{
		Clear ();
		for (int i = 0; i < grid.GamesList.Count; i++) {
			go = Instantiate (GridItemPrefab, GridContent);

			go.transform.GetChild (0).GetComponent <Image> ().sprite = grid.GamesList [i].GameIcon ?? defIcon;
			go.transform.GetChild (1).GetComponent <Text> ().text = grid.GamesList [i].GameName;

			go.GetComponent <GridItem> ().GameURL = grid.GamesList [i].GameURL;
			go.GetComponent <GridItem> ().GameIndex = i;
		}
	}

	public void Clear ()
	{
		int i = GridContent.childCount;
		while (i-- > 0) {
			go = GridContent.GetChild (0).gameObject;
			DestroyImmediate (go);
		}
	}
		
}

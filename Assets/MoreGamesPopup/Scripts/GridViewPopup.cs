using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class GridViewPopup : MonoBehaviour
{
	public Sprite defaultIcon;

	public RectTransform GridContent;
	public GameObject GridItemPrefab;

	[Serializable]
	public struct Game
	{
		public string GameName;
		public string GameURL;
		public Sprite GameIcon;
	}

	[Header ("--------------------------------------------------------------------------------")]
	[Space][Space][Space][Space]
	public List<Game> GamesList;

}

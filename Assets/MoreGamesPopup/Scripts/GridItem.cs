using UnityEngine;
using UnityEngine.UI;

public class GridItem : MonoBehaviour
{
	[HideInInspector] public string GameURL;
	[HideInInspector] public int GameIndex;
	Button btn;

	void Start ()
	{
		btn = GetComponent <Button> ();
		btn.onClick.AddListener (delegate {
			//This line executes when an item is clicked
			Application.OpenURL (GameURL);
		});
	}

	void OnDestroy ()
	{
		btn.onClick.RemoveAllListeners ();
	}
}

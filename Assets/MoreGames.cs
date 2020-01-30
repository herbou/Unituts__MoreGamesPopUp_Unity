using UnityEngine;

public class MoreGames : MonoBehaviour
{
	[SerializeField] GameObject moreGamesPopup;
	[SerializeField] float moreGamesDelay = 5f;

	void Start ()
	{
		Invoke ("ShowMoreGamesUI", moreGamesDelay);
	}

	public void ShowMoreGamesUI ()
	{
		moreGamesPopup.SetActive (true);
	}

	public void CloseMoreGamesUI ()
	{
		moreGamesPopup.SetActive (false);
	}
}

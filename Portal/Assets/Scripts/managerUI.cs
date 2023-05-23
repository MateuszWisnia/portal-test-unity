using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class managerUI : MonoBehaviour
{
	public Sprite blueOpenSprite;
	public Sprite redOpenSprite;
	public Sprite blueClosedSprite;
	public Sprite redClosedSprite;
	public Image blueImagePlace;
	public Image redImagePlace;

	public void UpdatePortalBlue(bool ZmianaBlue)
	{
		if (ZmianaBlue)
		{
			blueImagePlace.sprite = blueClosedSprite;
		}
		else
		{
			blueImagePlace.sprite = blueOpenSprite;
		}
	}
	public void UpdatePortalRed(bool ZmianaRed)
	{
		if (ZmianaRed)
		{
			redImagePlace.sprite = redClosedSprite;
		}
		else
		{
			redImagePlace.sprite = redOpenSprite;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

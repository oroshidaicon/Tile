// @file SnapTile.cs
// @author Okada Moeto

using UnityEngine;

[ExecuteInEditMode]
public class SnapTile : MonoBehaviour
{
	public float snapValue = 1.0f;
	
	void Update()
	{
		if(Application.isPlaying)
		{
			return;
		}
		
		float x, y;
		x = Mathf.Round(transform.position.x / snapValue) * snapValue;
		y = Mathf.Round(transform.position.y / snapValue) * snapValue;
		
		transform.position = new Vector3(x, y, 0.0f);
		
		GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(-y);
	}
}

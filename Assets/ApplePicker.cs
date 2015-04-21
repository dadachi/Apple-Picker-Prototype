using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;
	public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
		basketList = new List<GameObject>();
		for (int i=0; i<numBaskets; i++ ) {
			GameObject tBasketGO = Instantiate( basketPrefab ) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + ( basketSpacingY *i );
			tBasketGO.transform.position = pos;
			basketList.Add( tBasketGO );
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AppleDestroyed() {
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
		foreach ( GameObject tGO in tAppleArray ) {
			Destroy(tGO);
		}

		int basketIndex = basketList.Count-1;
		GameObject tBasketGO = basketList[basketIndex];
		basketList.RemoveAt( basketIndex );
		Destroy( tBasketGO );

		if ( basketList.Count == 0 ) {
			Application.LoadLevel( "_Scene_0" );
		}

	}
}

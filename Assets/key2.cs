using UnityEngine;
using System.Collections;

public class key2 : MonoBehaviour {

	public int playerX, playerZ;
	//public GameObject textObject;
	public Vector3[] verboten; 
	public Vector3 startPos;

	// Use this for initialization
	void Start () {

		playerX = 3;
		playerZ = -4;

		transform.position= new Vector3 (playerX, 0, playerZ);

		//textObject.GetComponent<TextMesh> ().text = "";

		startPos = new Vector3 (0, 0, 0);
	}

	// Update is called once per frame
	void Update () {


		playerZ = (int)transform.position.z; 
		playerX = (int)transform.position.x; 



		for (int i = 0; i < verboten.Length; i++) {
			if (transform.position == verboten [i]) {
				Debug.Log (" you got key 2" +
					"you win");	

				transform.position = startPos;





			}
		}
	}
}

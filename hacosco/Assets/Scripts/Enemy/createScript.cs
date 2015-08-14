using UnityEngine;
using System.Collections;

public class createScript : MonoBehaviour {
	
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	
	//public GameObject green1;
	//public GameObject green2;
	
	int border = 1000;
	int enemyBorder = 1;
	float defdiff = 100f;
	void Update ()
	{
		if (transform.position.z > border) {
			//CreateMap ();
		}
		if (transform.position.z > enemyBorder) {
			CreateEnemy ();
		}
	}
	
/*	void CreateMap(){
		if (green1.transform.position.z < border) {
			border += 2000;
			Vector3 temp = new Vector3 (0,0.05f,border);
			green1.transform.position = temp;
		} else if (green2.transform.position.z < border) {
			border += 2000;
			Vector3 temp = new Vector3 (0,0.05f,border);
			green2.transform.position = temp;
		}
	}
*/	
	void CreateEnemy (){

		if (Random.Range (0, 3) == 0) {
			Instantiate (enemy1, new Vector3 (-5f, 0f, enemyBorder + defdiff), enemy1.transform.rotation);

		}
		if (Random.Range (0, 3) == 0) {
			Instantiate (enemy2, new Vector3 (-1.8f, 0f, enemyBorder + defdiff), enemy2.transform.rotation);

		}
		if (Random.Range (0, 3) == 0) {
			Instantiate (enemy3, new Vector3 (1.8f, 0f, enemyBorder + defdiff), enemy3.transform.rotation);

		}
		if ((Random.Range (0, 3) == 0)) {
			Instantiate (enemy4, new Vector3 (5f, 0f, enemyBorder + defdiff), enemy3.transform.rotation);
		}
		enemyBorder += Random.Range (0, 3)*10;

	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moltresScript : MonoBehaviour {

	public Button fire2Button;

	public GameObject spawnPoint;

	public GameObject fireBall;

	// Use this for initialization

	void Start () {

		fire2Button.onClick.AddListener (fire2ButtonDown);

	}

	void fire2ButtonDown(){

		fireBall = Instantiate (Resources.Load ("FireMobile"), spawnPoint.transform.position, Quaternion.identity) as GameObject;

		fireBall.GetComponent<Rigidbody> ().AddRelativeForce (spawnPoint.transform.forward * -1000f);

		Destroy (fireBall, 2);

	}

	// Update is called once per frame void Update () { } }
}

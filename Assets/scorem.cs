using UnityEngine;
using System.Collections;

public class Bascket : MonoBehaviour {

	public ScoreText scoreText;　//外部のScoteTextオブジェクトを見えるよう定義

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "ball") {
			scoreText.GetComponent<ScoreText>().score++;
		}
	}
}

using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	private AudioClip audioClip;
	private AudioSource audioSouce;

	// Use this for initialization
	void Start(){
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Cube" || collision.gameObject.name == "ground") {
			audioSouce = GetComponent<AudioSource> ();
			audioSouce.PlayOneShot (audioSouce.clip);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
//		if (other.gameObject.tag == "Cube") {
//			audioSouce = gameObject.GetComponent<AudioSource> ();
//			audioSouce.clip = audioClip;
//			audioSouce.Play ();
//		}
	}
}

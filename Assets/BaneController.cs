using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaneController : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("ばねのテスト");
		// 当たった相手のタグがPlayerだった場合
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("ばねのテスト２");
			// 当たった相手のRigidbodyコンポーネントを取得して、上向きの力を加える
			var rb = other.GetComponent<Rigidbody2D>();
			var force = new Vector2(0.0f, 5000.0f);
			rb.AddForce(force, ForceMode2D.Impulse);
		}
	}
}

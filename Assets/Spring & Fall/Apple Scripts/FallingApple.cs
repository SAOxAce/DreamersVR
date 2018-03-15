﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingApple : MonoBehaviour {

	public float fallSpeed = 1.0f;

	void Update() {

		transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

	}
}

using UnityEngine;
using System.Collections;

public class CameraPixelScript : MonoBehaviour {

	void Awake ()
	{
		camera.orthographicSize = ((float)Screen.height) / 4;
	}
}

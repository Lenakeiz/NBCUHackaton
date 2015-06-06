using UnityEngine;
using System.Collections;

public class MoviePlayer : MonoBehaviour {

	public GUITexture gt;
	public WWW wwwdata;
	public string url = "http://igor.gold.ac.uk/~acast014/portfolio/bbSeason.ogg";
	string url_sample = "http://www.unity3d.com/webplayers/Movie/sample.ogg";

	// Use this for initialization
	void Start () {
		wwwdata =  new WWW(url);
		gt = GetComponent<GUITexture>();

		MovieTexture mm_text = wwwdata.movie as MovieTexture;

		gt.texture = wwwdata.movie;

		//this.transform.localScale = new Vector3(0.0f,0.0f,0.0f);
		//this.transform.position = new Vector3(0.5f,0.5f,0.0f);

		//gt.pixelInset = new Rect(-mm_text.width / 2.0f, mm_text.width / 2.0f, -mm_text.height / 2.0f, mm_text.height / 2.0f);

	}

	// Make sure we have gui texture and audio source
	//@script RequireComponent (GUITexture)
	//@script RequireComponent (AudioSource)
	
	// Update is called once per frame
	void Update () {

		MovieTexture m = gt.texture as MovieTexture;
		if(!m.isPlaying && m.isReadyToPlay)
		{
			m.Play();
		}
	}
}

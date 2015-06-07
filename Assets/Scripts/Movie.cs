using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movie {

    private string name;
    private string genre;
    private double rating;
    private int year;
    private List<string> reviews;
    private string trailer;
    private string url;

    public Movie(string _name, string _genre, double _rating, int _year, string _trailer, string _url)
    {
        reviews = new List<string>();
        this.name = _name;
        this.genre = _genre;
        this.rating = _rating;
        this.year = _year;
        this.trailer = _trailer;
        this.url = _url;
    }

    public void addReview(string _review)
    {
        reviews.Add(_review);
    }
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

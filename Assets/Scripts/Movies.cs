using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movies {

    private List<Movie> movies;


    public Movies()
    {
        Movie m;
        this.movies = new List<Movie>();

        m = new Movie("About Time", "Drama", 7.8, 2013, "abouttime.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);

        m = new Movie("Back to the Future", "Adventure", 8.5, 1985, "backtothefuture.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);

        m = new Movie("Despicable Me 2", "Animation", 7.5, 2013, "despicableme2.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Ex Machina", "Drama", 7.8, 2015, "exmachina.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Fast and Furious 6", "Action", 7.2, 2013, "fastandfurious6.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Les Miserables", "Drama", 7.7, 2012, "lesmiserables.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Oblivion", "Action", 7.0, 2013, "oblivion.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Pitch Perfect", "Comedy", 7.3, 2012, "pitchperfect.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);


        m = new Movie("Ted", "Comedy", 7.0, 2012, "ted.mp4");
        m.addReview("This is a great movie");
        movies.Add(m);




    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

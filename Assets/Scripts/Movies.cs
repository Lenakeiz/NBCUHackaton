using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movies {

    private List<Movie> movies;


    public Movies()
    {
        Movie m;
        this.movies = new List<Movie>();

        m = new Movie("About Time", "Drama", 7.8, 2013, "abouttime.avi", "http://www.findanyfilm.com/~51429");
        m.addReview("its the second time Rachel's got a time traveling/place shifting bf lmao :D");
        m.addReview("This trailer kind of prepared me for the wrong kind of crying. SPOILER ALERT I thought I'd cry because he screwed up and caused the events of Mary meeting him and falling in love with him not to happen but I ended up crying for the Dad.");
        m.addReview("Does this movie end sad? Because if yes I'm not gonna watch it");
        m.addReview("I need this skill! Â Oh so many mistakes to fix..");
        m.addReview("Es una pelicula EXTRAORDINARIA en todos los aspectos! de las mejores que he visto en mi vida! muy hermosa :)(L)");
        movies.Add(m);


        m = new Movie("Back to the Future", "Adventure", 8.5, 1985, "backtothefuture.avi", "http://www.findanyfilm.com/~57325");
        m.addReview("I think this movie is not worth 8.5 imdb, don't get me wrong this movie is great but it just like other kid movies on Disney channel, I'd give it 6.5 or 7");
        m.addReview("the whole movie in a trailer xDD");
        m.addReview("One Of My Favorite Movies Of All Time...No Pun Intended...M...");
        m.addReview("Back To The Future (1985) Theatrical Trailer - Michael J. Fox Movie HD: http://youtu.be/qvsgGtivCgs");
        m.addReview("Starting off a Back to the Future trilogy. First one all the way to the last. His mothers trying hard to get with him. lol. Would like to have a Delorean, there's apparently one company that still makes and sells them. Then he goes into the future, then to alternate reality and then finally back to the past. Awesome movies.");
        movies.Add(m);


        m = new Movie("Despicable Me 2", "Animation", 7.5, 2013, "despicableme2.avi", "http://www.findanyfilm.com/~47022");
        m.addReview("Eminem is approved for children?");
        m.addReview("Tonight's film is this");
        m.addReview("Despicable Me 2 Official Trailer #3 (2013) - Steve Carell Animated Movie HDÂ : http://youtu.be/koNSa_6Fd1U");
        m.addReview("");
        m.addReview("Song??");
        movies.Add(m);


        m = new Movie("Ex Machina", "Drama", 8.1, 2015, "exmachina.avi", "http://www.findanyfilm.com/~61488");
        m.addReview("And the Cinemasins guy inspires a generation!");
        m.addReview("Trailers these days -_- I'll be really surprised if the blond guy isn't a robot.");
        m.addReview("Is this one of those films that has a great tone but just sucks at the end?");
        m.addReview("Is it normal that i find this more scary than classic horror movies?");
        m.addReview("I'm looking forward to watching this. ");
        movies.Add(m);


        m = new Movie("Fast and Furious 6", "Action", 7.2, 2013, "fastandfurious6.avi", "http://www.findanyfilm.com/~39468");
        m.addReview("fast 5 was the best one .. so far :)");
        m.addReview("The Fast And The Furious now is not simply about racing illegally and stealing merchandise to gain money, its now about guys that were a bunch of street racers and low criminals and all of a sudden now have all the knowledge in the world to make a MISSION IMPOSSIBLE operation! they ruined the whole franchise! its like a combination of The Expendables with Mission Impossible! The best ones were The Fast and The Furious and Tokyo Drift which were more related to racing!");
        m.addReview("this was better than fast 7");
        m.addReview("Still a better love story than Twilight...Â ");
        m.addReview("Who is the blonde girl in the beginning of the trailer? Elsa pataky?");
        movies.Add(m);


        m = new Movie("Les Miserables", "Drama", 7.3, 1978, "lesmiserables.avi", "http://www.findanyfilm.com/~47944");
        m.addReview("That was one expensive loaf of bread.");
        m.addReview("This 1978 film adaptation of the world famous Victor Hugo's classic novel "Les Miserables" starring Richard Jordan is the best rendition effectively portraying the morally conflicting roles of Jean Valjean and Gavert played evocatively by Jordan and Anthony Perkins, respectively. Well Done!");
        m.addReview("Saw it. It was good BUT I was disappointed when Eponine wasnt in it. And I looove Eponine. She's my favorite character next to Jean Valjean");
        m.addReview("Anthony Perkins was a really good Javert :)");
        m.addReview("this is the best movie made for the story ever ");
        movies.Add(m);


        m = new Movie("Oblivion", "Action", 7, 2013, "oblivion.avi", "http://www.findanyfilm.com/~125599");
        m.addReview("Underrated movie.");
        m.addReview("I personally think this movie was great. It made you think, and it was one of those you have to watch from the beginning to understand the ending. Lots of plot twists, solid acting, nice script, outstanding visuals, and beautiful music. The ONLY thing that could have been better is if they trimmed off a lot of the landscaping shots (about 15 minutes or so) and focused more on the action. Because once the final 15 minutes came up, YES!");
        m.addReview("Does anybody know the name of the sexy font they used for this trailer?Â ");
        m.addReview("Think of this movie as a long music video. The shots and music work together very well.");
        m.addReview("wtf is this, i was looking for Oblivion");
        movies.Add(m);


        m = new Movie("Pitch Perfect", "Comedy", 7.3, 2012, "pitchperfect.avi", "http://www.findanyfilm.com/~125583");
        m.addReview("i sometimes have a feeling i can do crystal meth but then i think "mmm, better not"");
        m.addReview("I just been shot ðŸ• Love FAT AMY");
        m.addReview("How is that 'HD'?");
        m.addReview("The best is fat amy");
        m.addReview("The best is fat Amy");
        movies.Add(m);


        m = new Movie("Ted", "Comedy", 7, 2012, "ted.avi", "http://www.findanyfilm.com/~55292");
        m.addReview("");
        m.addReview("really good movie");
        m.addReview("Who did the narration? I cant find it anywhere in the credits - I found it Patrick stewart");
        m.addReview("This movie was funny and I cannot wait for the sequel this summer");
        m.addReview("The lesson of this movie is be careful what you wish for as it may come true and come back on you later XDDDDDD");
        movies.Add(m);


        m = new Movie("Furious Seven", "Action", 7.9, 2015, "furiousseven.avi", "http://www.findanyfilm.com/~57349");
        m.addReview("The New #Furious7 Trailer does not disappoint. If you need to put it on repeat, we understand.");
        m.addReview("Can't wait to watch it! Â ...................it is coming out this year.");
        m.addReview("Fast & Furious 7 coming on 4-3-2015 R.I.P Paul walker....");
        m.addReview("Â Guys a man is not dead when hes body is gone or anything like that.. a man is dead when he gets forgotten!");
        m.addReview("They should just replace Paul Walker with that guy who played the Joker in batman movie.. they looked the same...");
        movies.Add(m);


        m = new Movie("Pitch Perfect 2", "Comedy", 0, 2015, "pitchperfect2.avi", "http://www.findanyfilm.com/~61319");
        m.addReview("Get Ready Pitches. The Barden Bellas are back in an all new Pitch Perfect 2 Trailer!");
        m.addReview("OMG ITS FLULA!!!! HES IN THE MOVIE UGH!!");
        m.addReview("Anyone seen the new movie Pitch Perfect 2?? seanâ™¥");
        m.addReview("The only reason that I'm going to watch this movie is because of fat amy and FLULA!!!");
        m.addReview("Spoiler Alert: Pentatonix will end up winning the Championship.");
        movies.Add(m);


        m = new Movie("Jurassic World", "Action", 0, 2015, "jurassicworld.avi", "http://www.findanyfilm.com/~61743");
        m.addReview("The New 'Jurassic World' Trailer is here! #TheParkIsOpenÂ ");
        m.addReview("The park itself looks cool, BUT you would think after all the other jurassic park movies these scientists would've learned their lesson. Like, why on Earth would you purposely clone a fricken dinosaur.");
        m.addReview("Cinemasins will have a field day when this comes out...");
        m.addReview("Anyone else feel the tingles shoot down their spine?");
        m.addReview("Who the hell sends their children alone to a island full of dinosaurs? ");
        movies.Add(m);





    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

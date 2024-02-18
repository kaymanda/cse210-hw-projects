using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listVideo = new List<Video>();

        //First video with comments section

        Video v1 = new Video();
        v1._title = "Book review";
        v1._author = "Blake Scott";
        v1._length = 240;

        Comment c1c1 = new Comment();
        c1c1._name = "Scotlynn Rae";
        c1c1._text = "What a great review for this book";

        Comment c1c2 = new Comment();
        c1c2._name = "Crispin Freeman";
        c1c2._text = "That was a meh review";

        Comment c1c3 = new Comment();
        c1c3._name = "Susan Call";
        c1c3._text = "What a terrible review";

        //add comment to video

        v1.AddComments(c1c1);
        v1.AddComments(c1c2);
        v1.AddComments(c1c3);

        //Second video with comments section

        Video v2 = new Video();
        v2._title = "Gaming Fun!";
        v2._author = "Lizzy Link";
        v2._length = 300;

        Comment c2c1 = new Comment();
        c2c1._name = "Zelda Smith";
        c2c1._text = "This looks like such a fun game, I am totally going to download it.";

        Comment c2c2 = new Comment();
        c2c2._name = "Nancy Lou";
        c2c2._text = "I don't know if this is worth the money.";

        Comment c2c3 = new Comment();
        c2c3._name = "Tami Cook";
        c2c3._text = "What a waste of time and money.";

        //add comment to video

        v2.AddComments(c2c1);
        v2.AddComments(c2c2);
        v2.AddComments(c2c3);

        //Third video with comments section
        Video v3 = new Video();
        v3._title = "How to make bread";
        v3._author = "Kay Stewart";
        v3._length = 720;

        Comment c3c1 = new Comment();
        c3c1._name = "Nessa Johnson";
        c3c1._text = "You make it look so easy, I am definitely going to try and make bread.";

        Comment c3c2 = new Comment();
        c3c2._name = "Mav Berry";
        c3c2._text = "I bet is smell amazing in that kitchen.";

        Comment c3c3 = new Comment();
        c3c3._name = "Leslie Moore";
        c3c3._text = "I could do better. Yours looks a little burnt.";

        //add comment to video
        v3.AddComments(c3c1);
        v3.AddComments(c3c2);
        v3.AddComments(c3c3);

        //Need to display all videos
        v1.Display();
        v2.Display();
        v3.Display();


        

    }
}
using System;
using System.Runtime.InteropServices.Marshalling;
//main program calling classes
class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Philippians", 4,13); //middle child's favorite scripture
        Scripture s1 = new Scripture(r1,"I can do all things through Christ which strengtheneth me.");
        
        Reference r2 = new Reference("2 Nephi", 4,20,21); // oldest child's favorite scripture
        Scripture s2 = new Scripture(r2,"My God hath been my support; he hath led me through mine afflictions in the wilderness; and he hath preserved me upon the waters of the great deep. He hath filled me with his love, even unto the consuming of my flesh.");
        
        Reference r3 = new Reference("John", 16,13); // my favorite scripture
        Scripture s3 = new Scripture(r3,"Howbeit when he, the Spirit of turth, is come, he will guide you into all truth: for he shall not speak of himself; but whatsoever he shall hear, that shall he speak: and he will shew you things to come.");
        
        Reference r4 = new Reference("1 Nephi", 2,16); // youngest child's favorite scripture
        Scripture s4 = new Scripture(r4,"And it came to pass that I, Nephi, being exceedingly young, nevertheless being large in stature, and also having great desires to know of the mysteries of God, wherefore, I did cry unto the Lord; and behold he did visit me, and did soften my heart that I did believe all the words which had been spoken by my father; wherefore, I did not rebel against him like unto my brothers.");
        
        string press = "enter";

        List<Scripture> favoriteScriptures = new List<Scripture>();
        favoriteScriptures.Add(s1);
        favoriteScriptures.Add(s2);
        favoriteScriptures.Add(s3);
        favoriteScriptures.Add(s4);
        
        Random script = new Random();
        int number = script.Next(0,favoriteScriptures.Count());
        // need to use get?
        Scripture pickedScript = new Scripture(favoriteScriptures[number].GetReference(), favoriteScriptures[number].GetReference().GetDisplayText());
        pickedScript = favoriteScriptures[number];

        bool needToHide = pickedScript.IsCompletelyHidden();
        //while loop until quit or scripture runs through
        while ((press != "quit"))
        {
            //clear
            Console.Clear();
            // use get
            string scriptureChoice = pickedScript.GetReference().GetDisplayText();
            string line = pickedScript.GetDisplayText();

            Console.WriteLine($"{scriptureChoice} , {line}");

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            press = Console.ReadLine();
            
            if ((press == "quit") && (needToHide == true))
            {
                press = "quit";
            }
            else
            {
             pickedScript.HideRandomWords(1);
             needToHide = pickedScript.IsCompletelyHidden();   
            }


        }


    }

}
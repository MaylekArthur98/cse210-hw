using System;

class Program
{
    static void Main(string[] args)
    {
        Video banditoVideo= new Video();
        banditoVideo._author = "Johathan Joestar";
        banditoVideo._title = "Top 10 COD moments";
        banditoVideo._length = 60;

        Video slnVideo = new Video();
        slnVideo._author = "Joseph Joestar";
        slnVideo._title = "Historic events in america";
        slnVideo._length = 280;   

        Video csVideo = new Video();
        csVideo._author = "Johnny Joestar";
        csVideo._title = "MMA fights of the year";
        csVideo._length = 1800;

        Video joshVideo = new Video();
        joshVideo._author = "Jotaro Kujo";
        joshVideo._title = "Best Sights in Japan";
        joshVideo._length = 120;
        
        Comments banditoComment = new Comments();
        banditoComment._name = "ThisKoolDude";
        banditoComment._textOfComment = "This dudes aim is wicked!";
        Comments banditoComment1 = new Comments();
        banditoComment1._name = "PentaPrestiege";
        banditoComment1._textOfComment = "I could do better.";
        Comments BanditoComment2 = new Comments();
        BanditoComment2._name = "TheTrollMan";
        BanditoComment2._textOfComment = "Fornite is a better game why do pople still play COD.";
        Comments BanditoComment3 = new Comments();
        BanditoComment3._name = "GetRekted360noScope";
        BanditoComment3._textOfComment = "What were the attachments on their guns?";

        Comments slnComment = new Comments();
        slnComment._name = "HistoryBuffMan";
        slnComment._textOfComment = "The Civil War had too many casualities,";
        Comments slnComment1 = new Comments();
        slnComment1._name = "TheKnowItAll";
        slnComment1._textOfComment = "Can you do video on European history next?";
        Comments slnComment2 = new Comments();
        slnComment2._name = "Dr.MuffinMan";
        slnComment2._textOfComment = "Absoluetly tragic!";
        Comments slnComment3 = new Comments();
        slnComment3._name = "Karen";
        slnComment3._textOfComment = "This video is very inaccurate you should fact check before posting.";

        Comments csComment = new Comments();
        csComment._name = "MMAStud";
        csComment._textOfComment = "Mcgregor is the best fighter in history!";
        Comments csComment1 = new Comments();
        csComment1._name = "HandsDoTheTalking";
        csComment1._textOfComment = "I wanna see Leon Edwards vs Alex Pereira.";
        Comments csComment2 = new Comments();
        csComment2._name = "Kakarot";
        csComment2._textOfComment = "All these fights were brutal.";
        Comments csComment3 = new Comments();
        csComment3._name = "WeirdGuy345";
        csComment3._textOfComment = "BareKnuckle fighting is better.";

        Comments joshComment = new Comments();
        joshComment._name = "BigWeeb";
        joshComment._textOfComment = "Japanese culture = best culture.";
        Comments joshComment1 = new Comments();
        joshComment1._name = "SightSeeing78";
        joshComment1._textOfComment = "Japan is next on the list to visit hands down!";
        Comments joshComment2 = new Comments();
        joshComment2._name = "BeTheBest";
        joshComment2._textOfComment = "The food is real reason people go to japan.";
        Comments joshComment3 = new Comments();
        joshComment3._name = "CowboyOtter";
        joshComment3._textOfComment = "Whats the best sights in Italy?";


        banditoVideo.AddToCommentList(banditoComment);
        banditoVideo.AddToCommentList(banditoComment1);
        banditoVideo.AddToCommentList(BanditoComment2);
        banditoVideo.AddToCommentList(BanditoComment3);

        slnVideo.AddToCommentList(slnComment);
        slnVideo.AddToCommentList(slnComment1);
        slnVideo.AddToCommentList(slnComment2);
        slnVideo.AddToCommentList(slnComment3);

        csVideo.AddToCommentList(csComment);
        csVideo.AddToCommentList(csComment1);
        csVideo.AddToCommentList(csComment2);
        csVideo.AddToCommentList(csComment3);

        joshVideo.AddToCommentList(joshComment);
        joshVideo.AddToCommentList(joshComment1);
        joshVideo.AddToCommentList(joshComment2);
        joshVideo.AddToCommentList(joshComment3);



        banditoVideo.Display();
        slnVideo.Display();
        csVideo.Display();
        joshVideo.Display();
        
    }
}
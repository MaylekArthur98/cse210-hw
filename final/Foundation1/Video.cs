using System.Runtime.CompilerServices;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comments> _commentList; 
    
    public Video()
    {
        this._commentList = new List<Comments>();
    }
    public void GetNumOfComments(){
        Console.WriteLine($"There are "+ this._commentList.Count() + " comments:");
    }

    public void AddToCommentList(Comments comments){
        _commentList.Add(comments);
    }
    public void Display(){
        Console.WriteLine($"{_title} by {_author}: Legnth {_length} seconds");
        Console.WriteLine("");
        GetNumOfComments();
        foreach (Comments c in _commentList){
            c.DisplayComments();
        }
        Console.WriteLine("");

    }
}
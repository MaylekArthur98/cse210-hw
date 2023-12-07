public class Comments
{
    public string _name;
    public string _textOfComment;

    public Comments(){}


  

    public void DisplayComments(){
        Console.Write($"> User: {_name}-- {_textOfComment}");
        Console.WriteLine("");
    }
}
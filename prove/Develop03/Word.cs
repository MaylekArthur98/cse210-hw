public class Word {
    private string _text;
    private bool _isHidden;

    public void Hide(){
        this._isHidden = true; 
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public string GetDisplayText(){
        if (this._isHidden == true){
            return "_ _ _ _";
        } else {
            return this._text;
        }
    }
    public void SetText(string text){
        this._text = text;
    }
}
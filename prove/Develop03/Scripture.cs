using System.Runtime.CompilerServices;
using System.Text;

public class Scripture {
    private Reference _reference;
    private List<Word>_word; 
    public Scripture(Reference reference, string text){
        // to do, figure out text variable.
        this._word = new List<Word>();
        this._reference = reference;
        
        string[] tempArray = text.Split(' ');
        foreach(string scriptWord in tempArray){
            Word tempword = new Word();
            tempword.SetText(scriptWord);
            this._word.Add(tempword);
        }
    }
    public void HideRandomWords(int numberToHide){
        int totalNumOfWords = this._word.Count;
        for (int i = 0; i < numberToHide; i++){
            Random rnd = new Random();
            int indexOfWordsToHide = rnd.Next(totalNumOfWords);
            this._word.ElementAt(indexOfWordsToHide).Hide();
        }
        

    }
    public string GetDisplayText(){
        string reference =  _reference.GetDisplayText();
        StringBuilder sb = new StringBuilder();
        sb.Append(reference + " ");
        foreach(Word word in _word){
            sb.Append(word.GetDisplayText() + " ");
        }
        return sb.ToString();
    }

    public bool IsCompletelyHidden(){
        bool completelyHidden = true;
        foreach(Word word in _word){
            if (!word.IsHidden()){
                completelyHidden = false;
            }
        }
        return completelyHidden; 
    }


}
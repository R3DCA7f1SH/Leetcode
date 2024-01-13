namespace LeetCode.SourceCode.Easy;

public class ValidParenthesesSolution {
    public bool IsValid(string s) {
        var length=s.Length;
        var bracketMap=new Dictionary<char,char>() { ['(']=')', ['{']='}', ['[']=']' };
        var stackNeedToClose=new Stack<char>();
        bool isValid=false;
        for(int i=0; i<length; i++) {
            var currentSymbol=s[i];
            if(bracketMap.ContainsKey(currentSymbol)) { 
                if(i==length-1) {
                    return false;
                }
                stackNeedToClose.Push(bracketMap[currentSymbol]);
            } else {
                bool isPeekable=stackNeedToClose.TryPeek(out char peek);
                if(isPeekable && peek==currentSymbol){
                    isValid=true;
                    stackNeedToClose.Pop();
                } else {
                    return false;
                }
            }
            if(i==length-1 && stackNeedToClose.Count>0) {
                isValid=false;
            }
        }
        return isValid;
    }
}
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

Example 5:

Input: s = "([)]"

Output: false

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.

CODE:

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char ch in s){
            if(ch=='('||ch=='{'||ch=='['){
                stack.Push(ch);
            }else if((ch==')' && (stack.Count==0 || stack.Pop()!='('))||(ch=='}' && (stack.Count==0 || stack.Pop()!='{'))||(ch==']' && (stack.Count==0 || stack.Pop()!='['))){
                return false;
            }
        }
        return stack.Count==0;
    }
}

OUTPUT:

Runtime
2
ms
Beats
82.58%

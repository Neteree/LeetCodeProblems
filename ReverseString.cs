public class Solution {
    public void ReverseString(char[] s) {
        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while(leftIndex < rightIndex) {
            char temp = s[leftIndex];
            s[leftIndex] = s[rightIndex];
            s[rightIndex] = temp;
            
            leftIndex++;
            rightIndex--;
        }
    }
}

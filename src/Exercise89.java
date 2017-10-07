import java.util.HashSet;
import java.util.Set;

public class Exercise89 {
    Set<String> generateParens(int remaining) {
        Set<String> set = new HashSet<>();
        if(remaining == 0)
            set.add("");
        else {
            Set<String> prev = generateParens(remaining - 1);
            for(String str : prev) {
                for(int i = 0; i < str.length(); i++) {
                    if(str.charAt(i) == '(') {
                        String s = insertInside(str, i);
                        set.add(s);
                    }
                }
                // Base. Set data structure automatically checks for repeated entries
                set.add("()" + str);
            }
        }
        return set;
    }

    String insertInside(String str, int leftIndex) {
        String left = str.substring(0, leftIndex + 1);
        String right = str.substring(leftIndex + 1, str.length());
        return left + "()" + right;
    }
}

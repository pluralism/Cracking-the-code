public class Main11 {
    public static void main(String[] args) {
    }

    public static boolean isUniqueChars2(String str) {
        // size = 256 assuming that our char set is ASCII
        // Time complexity -> O(n)
        // Space complexity -> O(n)
        boolean[] char_set = new boolean[256];

        for(int i = 0; i < str.length(); i++) {
            int val = str.charAt(i);
            if(char_set[val])
                return false;
            char_set[val] = true;
        }
        return true;
    }


    public static boolean isUniqueChars(String str) {
        int checker = 0;
        for(int i = 0; i < str.length(); i++) {
            int val = str.charAt(i) - 'a';
            if((checker & (1 << val)) > 0)
                return false;
            checker |= (1 << val);
        }
        return true;
    }
}

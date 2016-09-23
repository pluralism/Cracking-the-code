public class Main13 {
    public static void main(String[] args) {
        char[] s = "aaaaaa".toCharArray();
        removeDuplicates(s);
        System.out.println(s);
    }


    public static void removeDuplicates(char[] str) {
        if(str == null)
            return;
        int len = str.length;
        if(len < 2)
            return;

        int tail = 1;

        for(int i = 1; i < len; ++i) {
            int j;
            for(j = 0; j < tail; ++j)
                if(str[i] == str[j])
                    break;

            if(j == tail) {
                str[tail] = str[i];
                ++tail;
            }
        }
        str[tail] = 0;
    }
}

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;

public class Exercise102 {
    public void sort(String[] array) {
        HashMap<String, List<String>> mapList = new HashMap<>();
        for(String s : array) {
            String key = sortChars(s);
            mapList.put(key, new ArrayList<String>() {{ add(s); }});
        }

        int index = 0;
        for(String key : mapList.keySet()) {
            List<String> list = mapList.get(key);
            for(String t : list)
                array[index++] = t;
        }
    }

    private String sortChars(String s) {
        char[] content = s.toCharArray();
        Arrays.sort(content);
        return new String(content);
    }
}

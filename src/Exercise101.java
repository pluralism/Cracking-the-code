public class Exercise101 {
    public void merge(int[] a, int[] b, int lastA, int lastB) {
        int indexA = lastA - 1;
        int indexB = lastB - 1;
        int indexMerged = indexA + indexB - 1;

        while(indexB >= 0) {
            if(indexA >= 0 && a[indexA] > b[indexB])
                a[indexMerged] = a[indexA--];
            else
                a[indexMerged] = b[indexB--];
            indexMerged--;
        }
    }
}

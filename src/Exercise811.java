public class Exercise811 {
    int makeChange(int amount, int[] denoms, int index) {
        // last one
        if(index >= denoms.length - 1)
            return 1;

        int denomAmount = denoms[index];
        int ways = 0;
        for(int i = 0; i * denomAmount <= amount; i++) {
            int remaining = amount - i * denomAmount;
            ways += makeChange(remaining, denoms, index + 1);
        }
        return ways;
    }
}

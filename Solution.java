
import java.util.HashMap;
import java.util.Map;

public class Solution {

    private static final int MODULO_VALUE = (int) Math.pow(10, 9) + 7;

    public int countNicePairs(int[] input) {
        Map<Integer, Integer> differenceToFrequency = new HashMap<>();
        int totalNicePairs = 0;

        for (int value : input) {
            int difference = value - reverseInteger(value);
            int frequency = differenceToFrequency.getOrDefault(difference, 0);
            totalNicePairs = (totalNicePairs + frequency) % MODULO_VALUE;
            differenceToFrequency.put(difference, frequency + 1);
        }
        return totalNicePairs;
    }

    private int reverseInteger(int value) {
        int reversed = 0;
        while (value > 0) {
            reversed = (reversed * 10) + (value % 10);
            value /= 10;
        }
        return reversed;
    }
}

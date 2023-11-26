
#include <cmath>
#include <vector>
using namespace std;

class Solution {
    
    inline static int MODULO_VALUE = pow(10, 9) + 7;

public:
    int countNicePairs(const vector<int>& input) const {
        unordered_map<int, int> differenceToFrequency;
        int totalNicePairs = 0;

        for (int value : input) {
            int difference = value - reverseInteger(value);
            int frequency = differenceToFrequency[difference];
            totalNicePairs = (totalNicePairs + frequency) % MODULO_VALUE;
            ++differenceToFrequency[difference];
        }
        return totalNicePairs;
    }
    
private:
    int reverseInteger(int value) const {
        int reversed = 0;
        while (value > 0) {
            reversed = (reversed * 10) + (value % 10);
            value /= 10;
        }
        return reversed;
    }
};

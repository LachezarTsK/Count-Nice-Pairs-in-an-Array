
/**
 * @param {number[]} input
 * @return {number}
 */
var countNicePairs = function (input) {
    const MODULO_VALUE = Math.pow(10, 9) + 7;
    const differenceToFrequency = new Map();
    let totalNicePairs = 0;

    for (let value of input) {
        let difference = value - reverseInteger(value);
        let frequency = differenceToFrequency.has(difference) ? differenceToFrequency.get(difference) : 0;
        totalNicePairs = (totalNicePairs + frequency) % MODULO_VALUE;
        differenceToFrequency.set(difference, frequency + 1);
    }
    return totalNicePairs;
};

/**
 * @param {number} value
 * @return {number}
 */
function reverseInteger(value) {
    let reversed = 0;
    while (value > 0) {
        reversed = (reversed * 10) + (value % 10);
        value = Math.floor(value / 10);
    }
    return reversed;
}

/**
 * @param {string} s
 * @return {number}
 */

var minLength = function (s) {
  let occurrences = ["AB", "CD"];
  let index = 0;

  while(index < s.length - 1) {
    let currentOccurance = s[index] + s[index+ 1];

    if(occurrences.includes(currentOccurance)){
        s = s.slice(0, index) + s.slice(index + 2);
        index = Math.max(0, index - 1);
    } else {
        index++;
    }
  }

  return s.length;
};

console.log(minLength("ABFCACDB"));

// Sliding Window Approach

// We have the string "ABFCACDB"
// We need to remove any occurrence of one substrings with are "AB" or "CD"
// We initialize a window that have the size of 2
// We start with the first to letters, then we are continuing to move the window thru the string
// If we encounter one of there combinations, we remove it from the string, and we reset the window to the start
// We do it until the window goes to the end of the string

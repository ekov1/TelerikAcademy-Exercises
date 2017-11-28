// number of all wheels - S
// 3 types of vehicles:
//  Cars with 4 wheels
//  Trucks with 10 wheels
//  Trikes with 3 wheels

// Constraints:
//  S will be between 1 and 200, inclusive.
//  Allowed working time for your program: 0.15 seconds.
//  Allowed memory: 16 MB.


function solve(args) {
    var s = +args[0],
        i,
        j,
        k,
        count = 0,
        sum = 0;

    // 10
    for (i = 0; i <= s / 10; i += 1) {
        // 4
        for (j = 0; j <= s / 4; j += 1) {
            //3
            for (k = 0; k <= s / 3; k += 1) {
                sum = (i * 10 + j * 4 + k * 3);
                if (sum == s) {
                    count += 1;
                }
            }
        }
    }

    return count;
}
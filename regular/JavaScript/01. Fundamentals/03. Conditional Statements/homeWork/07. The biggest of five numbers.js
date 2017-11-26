function biggestOf5(args) {
    var temp, biggest = args[0], i = 0;

    while (i < 5) {
        temp = +args[i];
        if (temp > biggest)
            biggest = temp;
        i += 1;
    }
    console.log(biggest);
}

function biggestOf5(args) {
    let big = -1.0/0;

    for (var x of args) {
        big = Math.max(big, x)
    }
    console.log(big);
}
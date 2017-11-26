function ExchangeIfGreater(args) {
    var a = +args[0],
        b = +args[1],
        big = Math.max(a, b);

    if (big === a) {
        console.log(b + " " + a);
    } else {
        console.log(a + " " + b);
    }
}


function solve(args) {
    var a = args[0];

    if (a == 0 || a == 1) {
        console.log("false");
        return;
    }

    if (a == 2 || a == 3 || a == 5 || a == 7) {
        console.log("true");
    }
    else
        if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0) {
            console.log("false");
        }
        else {
            console.log("true");
        }
}

solve(1);
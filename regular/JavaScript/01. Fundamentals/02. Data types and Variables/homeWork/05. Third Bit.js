function solve(args) {
    var a = args[0];
    a = a >>> 3;
    a = a.toString(2);
    a = a.slice(-1);

    console.log(a);

}
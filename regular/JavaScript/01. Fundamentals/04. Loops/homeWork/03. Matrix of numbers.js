function matrix(args) {
    var x = +args[0],
        result = "",
        i, j;

    for (i = 1; i <= x; i += 1) {
        result += i + " ";
        for (j = i + 1; j <= x + i - 1; j += 1) {
            result += j + " ";
        }
        result += "\n";
    }
    console.log(result);
}
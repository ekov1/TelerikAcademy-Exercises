function solve(args) {
    var x = +args[0],
        y = +args[1],
        distance = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)),
        result = "";

    if (distance <= 1.5) {
        result += 'inside circle ';
    } else {
        result += 'outside circle ';
    }

    //check if outside rectangle

    if (y > 1 || y < -1 || x < -1 || x > 5) {
        result += 'outside rectangle';
    } else {
        result += 'inside rectangle';
    }

    console.log(result);
}
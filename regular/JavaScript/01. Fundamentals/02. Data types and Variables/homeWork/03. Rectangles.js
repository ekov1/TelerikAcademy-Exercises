function solve(args){
    var width = +args[0],
        heigth = +args[1],
        perimeter = 2*width + 2*heigth,
        area = width*heigth;

        console.log( area.toFixed(2) + " " + perimeter.toFixed(2));
}
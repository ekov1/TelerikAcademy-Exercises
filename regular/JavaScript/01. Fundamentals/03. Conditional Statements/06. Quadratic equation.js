function quadraticE(args){
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = (b * b) - (4 * a * c),
        sqrtOFd = Math.sqrt(d),
        x1, x2;

    if (d > 0) {
        
        x1 = (-b - sqrtOFd) / (2 * a);
        x2 = (-b + sqrtOFd) / (2 * a); 
        if (x1 > x2) {
            var temp = x1;
            x1 = x2;
            x2 = temp;
        }
        console.log('x1=' + x1.toFixed(2) + "; x2=" + x2.toFixed(2));
    }
    else if (d === 0) {
        x1 = -b / (2 * a);
        console.log('x1=x2='+ x1.toFixed(2));
    }
    else if(d < 0){
        console.log('no real roots');
    }
}
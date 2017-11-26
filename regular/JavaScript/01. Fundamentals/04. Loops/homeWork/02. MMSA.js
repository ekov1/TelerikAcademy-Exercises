function solve(args){
    var min = +args[0],
        max = +args[0],
        sum = 0,
        avg = 0,
        i;
    
    for(i = 0; i < args.length; i += 1){
        if(min > +args[i]) min = +args[i];
        if(max < +args[i]) max = +args[i];
        sum += +args[i];
    }
    avg = sum / args.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}
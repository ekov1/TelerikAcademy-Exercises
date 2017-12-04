function solve(args) {
    var rowsCols = args[0].split(' '),
        bounds = {
            rows: +rowsCols[0],
            cols: +rowsCols[1]
        },
        matrix = args.slice(1)
            .map(function (line) {
                return line.split(' ');
            })

    return matrix;
}

var tests = [
    [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ],
    [
        '3 5',
        'dr dl dl ur ul',
        'dr dr ul ul ur',
        'dl dr ur dl ur'
    ]
];

tests.forEach(function (test) {
    console.log(solve(test));
});
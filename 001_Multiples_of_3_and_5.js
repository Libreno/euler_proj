var f1 = 1; 
var f2 = 2; 
var s = 2;

do {
    r = f1 + f2;
    if (r % 2 == 0){
        s += r;
    };
    f1 = f2; 
    f2 = r;
} while (r <= 4000000);

console.log(s);
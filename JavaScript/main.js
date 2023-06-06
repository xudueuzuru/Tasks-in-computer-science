function one(m, n) {
    if (m * 60 + n <= 384)
        console.log("поместится");
    else
        console.log("не поместится");
}


function two(m) {
    let result = 1;
    for (let i = 0; i < m.length - 1; i++) {
        if (m[i] + m[i + 1] <= 50)
            m[i + 1] += m[i];
        else
            result++;
    }
    console.log(result);
}


function three(m, n) {
    let result = 0;
    for (let i = m; i <= n; i++) {
        if (~~(i / 100000) + ~~(i / 10000) % 10 + ~~(i / 1000) % 10 === ~~(i / 100) % 10 + ~~(i / 10) % 10 + i % 10)
            result++;
    }
    console.log(result);
}


function four(n) {
    for (let y = 0; y <= ~~(n / 5); y++) {
        const x = ~~((n - 5 * y) / 3);
        if (3 * x + 5 * y === n)
            console.log(x, y);
    }
}

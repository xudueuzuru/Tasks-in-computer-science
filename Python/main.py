def one(m, n):
    if m * 60 + n <= 384:
        print("поместится")
    else:
        print("не поместится")


def two(m):
    result = 1
    for i in range(len(m) - 1):
        if m[i] + m[i + 1] <= 50:
            m[i + 1] += m[i]
        else:
            result += 1
    print(result)


def three(m, n):
    result = 0
    for i in range(m, n + 1):
        if i // 100000 + i // 10000 % 10 + i // 1000 % 10 == i // 100 % 10 + i // 10 % 10 + i % 10:
            result += 1
    print(result)


def four(n):
    for y in range(n // 5 + 1):
        x = (n - 5 * y) // 3
        if 3 * x + 5 * y == n:
            print(x, y)

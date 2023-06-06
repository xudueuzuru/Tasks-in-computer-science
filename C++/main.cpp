#include <iostream>

using namespace std;

void one(int m, int n) {
    if (m * 60 + n <= 384)
        cout << "fit\n";
    else
        cout << "not fit\n";
}


void two(int m[]) {
    int result = 1;
    for (int i = 0; i < 14; i++) {
        if (m[i] + m[i + 1] <= 50)
            m[i + 1] += m[i];
        else
            result++;
    }
    cout << result << endl;
}


void three(int m, int n) {
    int result = 0;
    for (int i = m; i <= n; i++) {
        if (i / 100000 + i / 10000 % 10 + i / 1000 % 10 == i / 100 % 10 + i / 10 % 10 + i % 10)
            result++;
    }
    cout << result << endl;
}

void four(int n) {
    for (int y = 0; y <= n / 5; y++) {
        int x = (n - 5 * y) / 3;
        if (3 * x + 5 * y == n)
            cout << x << ' ' << y << endl;
    }
}


int main() {
    return 0;
}

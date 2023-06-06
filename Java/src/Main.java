public class Main {
    static void one(int m, int n) {
        if (m * 60 + n <= 384)
            System.out.println("поместится");
        else
            System.out.println("не поместится");
    }


    static void two(int[] m) {
        int result = 1;
        for (int i = 0; i < m.length - 1; i++) {
            if (m[i] + m[i + 1] <= 50)
                m[i + 1] += m[i];
            else
                result++;
        }
        System.out.println(result);
    }


    static void three(int m, int n) {
        int result = 0;
        for (int i = m; i <= n; i++) {
            if (i / 100000 + i / 10000 % 10 + i / 1000 % 10 == i / 100 % 10 + i / 10 % 10 + i % 10)
                result++;
        }
        System.out.println(result);
    }


    static void four(int n) {
        for (int y = 0; y <= n / 5; y++) {
            int x = (n - 5 * y) / 3;
            if (3 * x + 5 * y == n)
                System.out.println(x + " " + y);
        }
    }


    public static void main(String[] args) {

    }
}

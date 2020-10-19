// https://www.hackerrank.com/challenges/java-loops/problem?isFullScreen=true
package hackerrank.loop2;

import java.util.*;
import java.io.*;

class Loop2 {

    public static int seriesSegment(int a, int b, int n) {
        int result = a;

        for (int i = 0; i <= n; i++) {
            result = (int) (result + Math.pow(2, i) * b);
        }

        return result;
    }

    public static void calculateSeries(int a, int b, int n) {
        for (int i = 0; i < n; i++) {
            System.out.print(seriesSegment(a, b, i));
            System.out.print(' ');
        }
    }

    public static void main(String[] argh) throws Exception {
        File file = new File("src\\main\\java\\hackerrank\\loop2\\input.txt");
        Scanner in = new Scanner(file);

        int t = in.nextInt();
        for (int i = 0; i < t; i++) {
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();

            calculateSeries(a, b, n);
            System.out.println();
        }

        in.close();
    }
}
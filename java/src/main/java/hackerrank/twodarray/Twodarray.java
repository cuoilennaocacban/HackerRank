// https://www.hackerrank.com/challenges/java-2d-array/problem?isFullScreen=true

package hackerrank.twodarray;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Twodarray {
    public static int getHourGlassValue(int startRow, int startCol, int[][] arr) {
        if (startRow > 3 || startCol > 3) {
            return 0;
        }

        return (arr[startRow][startCol] + arr[startRow][startCol + 1] + arr[startRow][startCol + 2])
                + arr[startRow + 1][startCol + 1]
                + (arr[startRow + 2][startCol] + arr[startRow + 2][startCol + 1] + arr[startRow + 2][startCol + 2]);
    }

    public static void getMaxHourglass(int[][] arr) {
        int max = Integer.MIN_VALUE;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                int value = getHourGlassValue(i, j, arr);
                if (max < value) {
                    max = value;
                }
            }
        }

        System.out.print(max);
    }

    public static void main(String[] args) throws FileNotFoundException {
        Scanner scanner = new Scanner(new File("src\\main\\java\\hackerrank\\twodarray\\input.txt"));

        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            String[] arrRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowItems[j]);
                arr[i][j] = arrItem;
            }
        }

        getMaxHourglass(arr);

        scanner.close();
    }

    // sample output: 19
}

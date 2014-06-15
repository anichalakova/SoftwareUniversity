package IntroductionToJava.Exercises;

import java.util.Scanner;

public class BitChecker {

	public static void main(String[] args) {
		int position = 3;
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int nRightPosition = n >> position;
        int bit = nRightPosition & 1;
        System.out.println(bit);
	}

}

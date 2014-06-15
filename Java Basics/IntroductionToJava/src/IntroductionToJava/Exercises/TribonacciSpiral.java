package IntroductionToJava.Exercises;

import java.util.Scanner;

public class TribonacciSpiral {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int firstNum = input.nextInt();
		int secondNum = input.nextInt();
		int thirdNum = input.nextInt();
		int total = 0;
		int[] trib = new int[1000000];
		
		int firstNumber = input.nextInt();
		int step = input.nextInt();
		int stepNumber = 0;
		int[] spiral = new int[1000000];
		
		for (int j = 0; j < 20; j++) {
			total = firstNum + secondNum + thirdNum;
			firstNum = secondNum;
			secondNum = thirdNum;
			thirdNum = total;
			trib[j] = total;
		}
		for (int i = 0; i < 20; i++) {
			stepNumber = firstNumber + step;
			firstNumber = stepNumber;
			spiral[i] = stepNumber;
		}
		
		for (int i : trib) {
			for (int j : spiral) {
				if (i == j) {
					System.out.println(i);
					return;
				}
				else {
					continue;
				}
			}
		}
	}

}

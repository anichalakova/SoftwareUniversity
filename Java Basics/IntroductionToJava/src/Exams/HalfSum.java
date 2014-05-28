package Exams;

import java.util.Scanner;

public class HalfSum {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int[] numbers = new int[2 * n];
		
		for (int i = 0; i < 2 * n; i++) {
			numbers[i] = input.nextInt();
		}
		
		int firstSum = 0;
		int secondSum = 0;
		
		for (int i = 0; i < numbers.length / 2; i++) {
			firstSum += numbers[i];
		}
		for (int i = n / 2; i < numbers.length; i++) {
			secondSum += numbers[i];
		}
		
		if (firstSum == secondSum) {
			System.out.println("Yes, sum = " + firstSum);
		}
		else if (firstSum > secondSum) {
			System.out.println("No, diff = " + (firstSum - secondSum));
		}
		else if (firstSum < secondSum) {
			System.out.println("No, diff = " + (secondSum - firstSum));
		}
	}

}

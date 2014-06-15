package Exams;

import java.util.Scanner;

public class NineDigitMagicNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = input.nextInt();
		int diff = input.nextInt();
		boolean foundAny = false;
		
		for (int n1 = 111; n1 < 777; n1++) {
			int n2 = n1 + diff;
			int n3 = n2 + diff;
			if (sumOfDigits(n1) + sumOfDigits(n2) + sumOfDigits(n3) == sum
					&& isCorrect(n1) && isCorrect(n2) && isCorrect(n3)) {
				foundAny = true;
				System.out.println(n1 + "" + n2 + "" + n3);
			}
			if (!foundAny) {
				System.out.println("No");
			}
		}
	}
	public static int sumOfDigits(int n) {
		int n1 = n / 100;
		int n2 = n % 100 / 10;
		int n3 = n % 10;
		
		return n1 + n2 + n3;
	}
	public static boolean isCorrect(int n) { 
		int n1 = n / 100;
		int n2 = n % 100 / 10;
		int n3 = n % 10;

		return n1 > 0 && n1 < 8 && n2 > 0 && n2 < 8 && n3 > 0 && n3 < 8;
	}

}

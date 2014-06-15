package Exams;

import java.util.Scanner;

public class TwoFourEight {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int result = 0;
		
		int c = num % 10;
		num /= 10;
		int b = num % 10;
		num /= 10;
		int a = num % 10;
		num /= 10;
		
		if (b == 2) {
			result = a % c;
		}
		else if (b == 4) {
			result = a + c;
		}
		else if (b == 8) {
			result = a * c;
		}
		
		if (result % 4 == 0) {
			System.out.println(result / 4);
			System.out.println(result);
		}
		else {
			System.out.println(result % 4);
			System.out.println(result);
		}
	}

}

package IntroductionToJava.Exercises;

import java.util.Scanner;

public class PrimeNumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int counter = 0;
		
		for (int i = 1; i <= num; i++) {
			if (num % i == 0) {
				counter++;
			}
		}
		
		if (counter > 2) {
			System.out.println("No");
		}
		else {
			System.out.println("Yes");
		}
	}

}

package IntroductionToJava.Exercises;

import java.util.Scanner;

public class MathWithMethods {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("To reverse the order of the digits press 1.");
		System.out.println("To sum the average press 2.");
		System.out.println("To solve an equation press 3.");
		
		
		int choice = input.nextInt();
		if (choice == 1) {
			System.out.print("Write down the number: ");
			int number = input.nextInt();
			System.out.println(reverseDigits(number));
		}
		else if (choice == 2) {
			System.out.println("How many numbers do you want to find the average of?");
			int number = input.nextInt();
			System.out.println(findAverage(number));
		}
		else if (choice == 3) {
			System.out.println("Enter \"a\" and \"b\" to find the answer of a * x + b = 0");
			int a = input.nextInt();
			int b = input.nextInt();
			System.out.println(solveEquation(a, b));
		}
	}
	public static int reverseDigits(int number) {
		int c = number % 10;
		number /= 10;
		int b = number % 10;
		number /= 10;
		int a = number % 10;
		
		System.out.print(c);
		System.out.print(b);
		return a;
		
	}
	public static int findAverage(int number) {
		Scanner input = new Scanner(System.in);
		
		int[] numbers = new int[number];
		int totalSum = 0;
		
		for (int i = 0; i < number; i++) {
			System.out.print("Please insert the next number: ");
			numbers[i] = input.nextInt();
		}
		
		for (int i : numbers) {
			totalSum += i;
		}
		
		System.out.print("The average is: ");
		return totalSum / number;
	}
	public static int solveEquation(int a, int b) {
		System.out.println(a + " * x + " + b + " = 0");
		System.out.println("x = b / a");
		int x = b / a;
		System.out.println("The answer is: ");
		return x;
	}

}

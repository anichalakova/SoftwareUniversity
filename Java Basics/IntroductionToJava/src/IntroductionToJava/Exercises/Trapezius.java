package IntroductionToJava.Exercises;

import java.util.Scanner;

public class Trapezius {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		int h = input.nextInt();
		
		System.out.println("The area is: " + ((a + b) / 2) * h);
		
	}

}

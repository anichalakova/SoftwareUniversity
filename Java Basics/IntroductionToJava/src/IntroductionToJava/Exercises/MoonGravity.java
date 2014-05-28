package IntroductionToJava.Exercises;

import java.util.Scanner;

public class MoonGravity {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int weight = input.nextInt();
		double moonWeight = (weight * 0.17);
		System.out.println("Your weight on the moon is " + moonWeight);
	}

}

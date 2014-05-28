package IntroductionToJava.Exercises;

import java.util.Scanner;

public class Circle1 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = input.nextInt();
		int y = input.nextInt();
		
		if (x <= 5 && y <= 5) {
			System.out.println("The point is inside the circle");
		}
		else {
			System.out.println("The point is outside the circle");
		}
	}

}

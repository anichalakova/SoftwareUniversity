package IntroductionToJava.Exercises;

import java.util.Scanner;

public class Circle2 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x = input.nextInt();
		int y = input.nextInt();
		
		if (x <=5 && y <= 5) {
			System.out.println("The point is in the circle");
			if (x < - 1 && y < 1) {
				System.out.println("The point is outside the rectangle");
			}
			else {
				System.out.println("The point is inside the rectangle");
			}
		}
		else {
			System.out.println("The point is outside the circle");
		}
	}

}

package IntroductionToJava.Exercises;

import java.util.Scanner;

public class RectanglePerimeterAndArea {

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int m = input.nextInt();
		
		System.out.println("The area is " + n * m);
		System.out.println("The perimeter is " + (2 * n) + (2 * m));
	}

}

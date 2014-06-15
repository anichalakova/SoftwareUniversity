package IntroductionToJava.Exercises;

import java.util.Scanner;

public class FourDigitNumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		
		int d = num % 10;
		num /= 10;
		int c = num % 10;
		num /= 10;
		int b = num % 10;
		num /= 10;
		int a = num;
		
		System.out.println(a + b + c + d);
		System.out.print(d);System.out.print(c);System.out.print(b);System.out.println(a);
		System.out.println(d + " " + a + " " + b + " " + c);
		System.out.println(a + " " + c + " " + d + " " + b);
	}

}

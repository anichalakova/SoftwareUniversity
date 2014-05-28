package Exams;

import java.util.Scanner;

public class SimpleLoops {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int num1 = input.nextInt();
		int num2 = input.nextInt();
		int num3 = input.nextInt();
		int result = 0;
		
		if (n == 1) {
			System.out.println(num1);
		}
		else if (n == 2) {
			System.out.println(num2);
		}
		else if (n == 3) {
			System.out.println(num3);
		}
		else {
			for (int i = 4; i <= n; i++) {
				result = num1 + num2 + num3;
				num1 = num2;
				num2 = num3;
				num3 = result;
			}
			System.out.println(num3);			
		}
	}

}

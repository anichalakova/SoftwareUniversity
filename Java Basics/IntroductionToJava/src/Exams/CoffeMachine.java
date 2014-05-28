package Exams;

import java.util.Scanner;

public class CoffeMachine {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n1 = input.nextInt();
		int n2 = input.nextInt();
		int n3 = input.nextInt();
		int n4 = input.nextInt();
		int n5 = input.nextInt();
		double a = input.nextDouble();
		double p = input.nextDouble();
		
		double vendorAmount = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1);
		double change = a - p;
		
		if (change >= 0) {
			if (vendorAmount >= change) {
				System.out.printf("Yes %.2f", (vendorAmount - change));
			}
			else if (vendorAmount < change) {
				System.out.printf("No %.2f", (change - vendorAmount));
			}
		}
		else {
			System.out.printf("More %.2f", (p - a));
		}
	}

}

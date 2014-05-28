package Exams;

import java.util.Scanner;

public class NightmareOnCodeStreet {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.next();
		int[] numbers = new int[text.length()];
		int counter = 0;
		
		for (int i = 0; i < text.length(); i++) {
			if (i % 2 == 0) {
				continue;
			}
			else {
				numbers[i] = Character.digit(text.charAt(i), 10);
			}
		}
		
		int sum = 0;
		
		for (int i : numbers) {
			sum += i;
		}
		
		System.out.println(sum);
	}

}

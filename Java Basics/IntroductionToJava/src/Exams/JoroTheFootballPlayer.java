package Exams;

import java.util.Scanner;

public class JoroTheFootballPlayer {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		char typeOfYear = input.findInLine(".").charAt(0);
		int p = input.nextInt();
		int h = input.nextInt();
		
		double normalPlays = ((52d - h) / 3d) * 2d;
		double holidayPlays = p / 2d;
		double homePlays = h;
		
		double sum = normalPlays + holidayPlays + homePlays;
		
		if (typeOfYear == 't') {
			sum = sum + 3;
		}
		System.out.println((int)sum);
	}

}

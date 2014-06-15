package Exams;

import java.util.Scanner;

public class SimpleDrawing {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		
		int width = n;
		char symbol = '*';
		char empty = '.';
		
		for (int i = 0; i < n; i++) {
			System.out.print(symbol);
		}
		System.out.println();
		
		int stars = n - 2;
		int emptySpaces = (n - stars) / 2;
		for (int i = 0; i < n / 2; i++) {
			System.out.print(DrawFigure(emptySpaces, empty));
			System.out.print(DrawFigure(stars, symbol));
			System.out.println(DrawFigure(emptySpaces, empty));
			stars -= 2;
			emptySpaces++;
		}
		
		stars += 2;
		emptySpaces--;
		
		for (int i = 0; i < (n / 2) - 1; i++) {
			stars += 2;
			emptySpaces--;
			System.out.print(DrawFigure(emptySpaces, empty));
			System.out.print(DrawFigure(stars, symbol));
			System.out.println(DrawFigure(emptySpaces, empty));
		}
		for (int i = 0; i < n; i++) {
			System.out.print(symbol);
		}
	}
	public static char DrawFigure(int n, char symbol) {
		
		for (int i = 0; i < n - 1; i++) {
			System.out.print(symbol);
		}
		return symbol;
	}

}

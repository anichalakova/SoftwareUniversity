package Exams;

import java.util.Scanner;

public class Sunglasses {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		
		char frame = '*';
		char glass = '/';
		char bridge = '|';
		char empty = ' ';
		
		System.out.print(CreateSymbols(n * 2, frame));
		System.out.print(CreateSymbols(n, empty));
		System.out.println(CreateSymbols(n * 2, frame));
		
		for (int i = 0; i < (n / 2) - 1; i++) {
			System.out.print(frame);
			System.out.print(CreateSymbols((n * 2) - 2, glass));
			System.out.print(frame);
			System.out.print(CreateSymbols(n, empty));
			System.out.print(frame);
			System.out.print(CreateSymbols((n * 2) - 2, glass));
			System.out.println(frame);
		}
		System.out.print(frame);
		System.out.print(CreateSymbols((n * 2) - 2, glass));
		System.out.print(frame);
		System.out.print(CreateSymbols(n, bridge));
		System.out.print(frame);
		System.out.print(CreateSymbols((n * 2) - 2, glass));
		System.out.println(frame);
		
		for (int i = 0; i < (n / 2) - 1; i++) {
			System.out.print(frame);
			System.out.print(CreateSymbols((n * 2) - 2, glass));
			System.out.print(frame);
			System.out.print(CreateSymbols(n, empty));
			System.out.print(frame);
			System.out.print(CreateSymbols((n * 2) - 2, glass));
			System.out.println(frame);
		}
		
		System.out.print(CreateSymbols(n * 2, frame));
		System.out.print(CreateSymbols(n, empty));
		System.out.println(CreateSymbols(n * 2, frame));
	}
	
	public static char CreateSymbols (int n, char symbol){
		for (int i = 0; i < n - 1; i++) {
			System.out.print(symbol);
		}
		return symbol;
	}

}

package IntroductionToJava.Exercises;

import java.util.Scanner;

public class DividableBy7 
{

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Please insert number: ");
		int n = input.nextInt();
		
		n = n / 10;
		n = n / 10;
		
		if (n % 10 == 7) 
		{
			System.out.println("Yes");
		}
		else 
		{
			System.out.println("No");
		}
	}

}

import java.util.Scanner;


public class SmallestOfThreeNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		int c = input.nextInt();
		
		int smallest = a;
		
		if (smallest > b) {
			smallest = b;
			if (smallest > c) {
				smallest = c;
			}
		}
		else if (smallest > c) {
			smallest = c;
			if (smallest > b) {
				smallest = b;
			}
		}
		
		System.out.println(smallest);
	}

}

import java.util.ArrayList;
import java.util.Scanner;


public class PythagoreanNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int[] numbers = new int[n]; 
		int count = 0;
		ArrayList<Integer> used = new ArrayList<> ();
		
		for (int i = 0; i < n; i++) {
			numbers[i] = input.nextInt();
		}
		
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers.length; j++) {
				for (int k = 0; k < numbers.length; k++) {
					if ((numbers[i] * numbers[i]) + (numbers[j] * numbers[j]) == (numbers[k] * numbers[k])) {
						if (used.contains(numbers[j])) {
							continue;
						}
						else {
							count++; 
							if (numbers[i] < numbers[j]) {
								System.out.printf("%d*%d + %d*%d = %d*%d", numbers[i], numbers[i], numbers[j], numbers[j],
										numbers[k], numbers[k]);
								System.out.println();
							}
							else if (numbers[i] == numbers[j]) {
								System.out.printf("%d*%d + %d*%d = %d*%d", numbers[i], numbers[i], numbers[j], numbers[j],
										numbers[k], numbers[k]);
								System.out.println();
							}
							else if (numbers[j] < numbers[i]) {
								System.out.printf("%d*%d + %d*%d = %d*%d", numbers[j], numbers[j], numbers[i], numbers[i],
										numbers[k], numbers[k]);
								System.out.println();
							}
							
							used.add(numbers[i]);
						}
					}
				}
			}
		}
		if (count == 0) {
			System.out.println("No");
		}
	}

}

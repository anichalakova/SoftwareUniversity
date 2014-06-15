import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] strings = new String[n];
		
		for (int i = 0; i < n; i++) {
			strings[i] = input.next();
		}
		
		Arrays.sort(strings);
		
		for (int i = 0; i < n; i++) {
			System.out.println(strings[i]);
		}
	}

}

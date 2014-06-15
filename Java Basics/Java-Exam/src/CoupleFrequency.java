import java.util.ArrayList;
import java.util.Scanner;

public class CoupleFrequency {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		double couples = 0;
		double totalCouples = 0;
		
		String[] numbers = input.split(" ");
		ArrayList<String> used = new ArrayList<> ();
		
		for (int i = 0; i < numbers.length - 1; i++) {
		String couple = numbers[i] + " " + numbers[i + 1];
		if (used.contains(couple)) {
			continue;
		}
		else {
			used.add(couple);
			for (int j = 0; j < numbers.length - 1; j++) {
				String testCouple = numbers[j] + " " + numbers[j + 1];
				if (couple.equals(testCouple)) {
					couples++;
				}
			}
		}
		totalCouples += couples;
		couples = 0;
	    }
		
		used.clear();
		
		for (int i = 0; i < numbers.length - 1; i++) {
			String couple = numbers[i] + " " + numbers[i + 1];
			if (used.contains(couple)) {
				continue;
			}
			else {
				used.add(couple);
				for (int j = 0; j < numbers.length - 1; j++) {
					String testCouple = numbers[j] + " " + numbers[j + 1];
					if (couple.equals(testCouple)) {
						couples++;
					}
				}
			}
			System.out.printf("%s -> %.2f%%",couple, (couples / totalCouples) * 100);
			System.out.println();
			couples = 0;
		}
	}
}
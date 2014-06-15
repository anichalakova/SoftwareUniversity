import java.util.Scanner;


public class Illuminati {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		input.close();
		text = text.replaceAll(" ", "");
		char[] chars = text.toCharArray();
		int sum = 0;
		int counter = 0;
		
		for (char c : chars) {
			if (c == 'A' || c == 'a' || c == 'I' || c == 'i' || c == 'E' || c == 'e' 
					|| c == 'O' || c == 'o' || c == 'U' || c == 'u') {
				if (c == 'A' || c == 'a' ) {
					counter++;
					sum += 65;
				}
				else if (c == 'I' || c == 'i' ) {
					counter++;
					sum += 73;
				}
				else if (c == 'E' || c == 'e' ) {
					sum += 69;
					counter++;
				}
				else if (c == 'O' || c == 'o' ) {
					sum += 79;
					counter++;
				}
				else if (c == 'U' || c == 'u') {
					sum += 85;
					counter++;
				}
			}
			
		}
		System.out.println(counter);
		System.out.println(sum);
	}

}

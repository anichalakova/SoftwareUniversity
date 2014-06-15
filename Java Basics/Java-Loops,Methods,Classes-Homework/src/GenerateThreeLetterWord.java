import java.util.Scanner;


public class GenerateThreeLetterWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String characters = input.next();
		char[] chars = characters.toCharArray();
		
		generateWords(chars);
		
	}
	public static void generateWords(char[] chars) {
		if (chars.length == 1) {
			for (int i = 0; i < 3; i++) {
				System.out.println(chars[0]);				
			}
		}
		else if (chars.length == 2) {
			for (int i = 0; i < chars.length; i++) {
				for (int j = 0; j < chars.length; j++) {
					System.out.printf("%c%c", chars[i], chars[j]);
					System.out.println();
				}
			}
		}
		else {
			for (int i = 0; i < chars.length; i++) {
				for (int j = 0; j < chars.length; j++) {
					for (int h = 0; h < chars.length; h++) {
						System.out.printf("%c%c%c", chars[i], chars[j], chars[h]);
						System.out.println();
					}
				}
			}			
		}
		
	}

}
